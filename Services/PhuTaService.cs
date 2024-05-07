using Repositories.Entities;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class PhuTaService
    {
        private PhuTaRepo _repo = new PhuTaRepo();

        public List<Phuta> GetAll() { return _repo.GetAll(); }

        public Phuta GetPhuTa(string id)
        {
            return _repo.Get(id);
        }
        public void AddPhuTa(Phuta phuta)
        {
            _repo.Create(phuta);
        }

        public void UpdatePhuTa(Phuta phuta)
        {
            _repo.Update(phuta);
        }

        public void DeletePhuTa(string ptId)
        {
            _repo.Delete(ptId);
        }

        public List<Phuta> SearchPhuTa(string id)
        {
            return _repo.GetAll().Where(x => x.MaPt.ToLower().Equals(id.ToLower())).ToList();
        }

        public string GeneratePhuTaID()
        {
            var newestID = _repo.GetAll().OrderByDescending(x => x.MaPt).FirstOrDefault()?.MaPt;
            var newID = "";

            if (string.IsNullOrEmpty(newestID))
            {
                newID = "PT001";
            }
            else
            {
                int number = int.Parse(newestID.Substring(2)) + 1;
                newID = "PT" + number.ToString("D3");
            }
            return newID;
        }
    }
}
