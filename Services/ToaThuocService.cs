using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ToaThuocService
    {
        private ToaThuocRepo _repo = new ToaThuocRepo();

        public List<Toathuoc> GetAll() { return _repo.GetAll(); }

        public Toathuoc? GetToathuoc(string id)
        {
            return _repo.Get(id);
        }

        public string? GetIDToaByPkbID(string pkbID)
        {
            return _repo.GetByPkbID(pkbID)?.MaToa;
        }

        public void AddToa(Toathuoc toathuoc)
        {
            _repo.Create(toathuoc);
        }

        public void UpdateToa(Toathuoc toathuoc)
        {
            _repo.Update(toathuoc);
        }

        public void DeleteToa(string toaId)
        {
            _repo.Delete(toaId);
        }

        public List<Toathuoc> SearchLeTan(string id)
        {
            return _repo.GetAll().Where(x => x.MaToa.ToLower().Equals(id.ToLower())).ToList();
        }

        public string GenerateID()
        {
            var newestID = _repo.GetAll().OrderByDescending(x => x.MaToa).FirstOrDefault()?.MaToa;
            var newID = "";

            if (string.IsNullOrEmpty(newestID))
            {
                newID = "TOA001";
            }
            else
            {
                string numberPart = newestID.Substring(3); // Bỏ qua "TOA" để chỉ lấy phần số
                if (int.TryParse(numberPart, out int number))
                {
                    number++; // Tăng số lên 1
                    newID = "TOA" + number.ToString("D3"); // Format lại mã toa
                }
            }

            return newID;
        }

    }
}
