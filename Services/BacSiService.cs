using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BacSiService
    {
        private BacSiRepo _repo = new BacSiRepo();

        public List<Bacsi> GetAll() { return _repo.GetAll(); }

        public Bacsi? GetBacsi(string id)
        {
            return _repo.Get(id);
        }

        public Bacsi? GetByPhone(string sdt)
        {
            return _repo.GetByPhone(sdt);
        }

        public void AddBacSi(Bacsi bacsi)
        {
            _repo.Create(bacsi);
        }

        public void UpdateBacSi(Bacsi bacsi)
        {
            _repo.Update(bacsi);
        }

        public void DeleteBacSi(string bsId)
        {
            _repo.Delete(bsId);
        }

        public List<Bacsi> SearchBacSi(string id)
        {
            return _repo.GetAll().Where(x => x.MaBs.ToLower().Equals(id.ToLower())).ToList();
        }

        public string GenerateBacSiID()
        {
            var newestID = _repo.GetAll().OrderByDescending(x => x.MaBs).FirstOrDefault()?.MaBs;
            var newID = "";

            if (string.IsNullOrEmpty(newestID))
            {
                newID = "BS001";
            }
            else
            {
                int number = int.Parse(newestID.Substring(2)) + 1;
                newID = "BS" + number.ToString("D3");
            }
            return newID;
        }
    }
}
