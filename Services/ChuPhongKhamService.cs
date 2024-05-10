using Repositories.Entities;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ChuPhongKhamService
    {
        private ChuPhongKhamRepo _repo = new ChuPhongKhamRepo();

        public List<Chuphongkham> GetAll() { return _repo.GetAll(); }

        public Chuphongkham? getChuphongkham(string id)
        {
            return _repo.Get(id);
        }

        public Chuphongkham? GetByPhone(string sdt)
        {
            return _repo.GetByPhone(sdt);
        }

        public void AddChuPhongKham(Chuphongkham chuphongkham)
        {
            _repo.Create(chuphongkham);
        }

        public void UpdateChuPhongKham(Chuphongkham chuphongkham)
        {
            _repo.Update(chuphongkham);
        }

        public void DeleteChuPhongKham(string cpkId)
        {
            _repo.Delete(cpkId);
        }

        public List<Chuphongkham> SearchBacSi(string id)
        {
            return _repo.GetAll().Where(x => x.MaCpk.ToLower().Equals(id.ToLower())).ToList();
        }

        public string GenerateBacSiID()
        {
            var newestID = _repo.GetAll().OrderByDescending(x => x.MaCpk).FirstOrDefault()?.MaCpk;
            var newID = "";

            if (string.IsNullOrEmpty(newestID))
            {
                newID = "CPK001";
            }
            else
            {
                int number = int.Parse(newestID.Substring(2)) + 1;
                newID = "CPK" + number.ToString("D3");
            }
            return newID;
        }
    }
}
