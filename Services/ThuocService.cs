using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ThuocService
    {
        ThuocRepo _repo = new ThuocRepo();

        public List<Thuoc>? GetAll() { return _repo.GetAll(); }

        public Thuoc? GetThuoc(string id)
        {
            return _repo.Get(id);
        }

        public Thuoc? GetByName(string name)
        {
            return _repo.GetByName(name);
        }

        public void AddThuoc(Thuoc toathuoc)
        {
            _repo.Create(toathuoc);
        }

        public void UpdateThuoc(Thuoc toathuoc)
        {
            _repo.Update(toathuoc);
        }

        public void DeleteThuoc(string toaId)
        {
            _repo.Delete(toaId);
        }

        public List<Thuoc> SearchLeTan(string id)
        {
            return _repo.GetAll().Where(x => x.MaThuoc.ToLower().Equals(id.ToLower())).ToList();
        }

        public string GenerateID()
        {
            var newestID = _repo.GetAll().OrderByDescending(x => x.MaThuoc).FirstOrDefault()?.MaThuoc;
            var newID = "";

            if (string.IsNullOrEmpty(newestID))
            {
                newID = "T001";
            }
            else
            {
                int number = int.Parse(newestID.Substring(2)) + 1;
                newID = "T" + number.ToString("D3");
            }
            return newID;
        }
    }
}
