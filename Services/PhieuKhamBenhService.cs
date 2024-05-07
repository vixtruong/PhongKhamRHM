using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class PhieuKhamBenhService
    {
        private PhieuKhamBenhRepo _repo = new PhieuKhamBenhRepo();

        public List<Phieukhambenh> GetAll() { return _repo.GetAll(); }

        public Phieukhambenh GetPhieukhambenh(string id)
        {
            return _repo.Get(id);
        }
        public void AddPhieuKhamBenh(Phieukhambenh phieukhambenh)
        {
            _repo.Create(phieukhambenh);
        }

        public void UpdatePhieuKhamBenh(Phieukhambenh phieukhambenh)
        {
            _repo.Update(phieukhambenh);
        }

        public void DeletePhieuKhamBenh(string ltId)
        {
            _repo.Delete(ltId);
        }

        public List<Phieukhambenh> SearchPhieuKhamBenh(string id)
        {
            return _repo.GetAll().Where(x => x.MaPkb.ToLower().Equals(id.ToLower())).ToList();
        }

        public string GeneratePhieuKhamBenhID()
        {
            var newestID = _repo.GetAll().OrderByDescending(x => x.MaPkb).FirstOrDefault()?.MaPkb;
            var newID = "";

            if (string.IsNullOrEmpty(newestID))
            {
                newID = "PKB001";
            }
            else
            {
                int number = int.Parse(newestID.Substring(3)) + 1;
                newID = "PKB" + number.ToString("D3");
            }
            return newID;
        }
    }
}
