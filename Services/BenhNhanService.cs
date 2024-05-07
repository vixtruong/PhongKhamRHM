using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BenhNhanService
    {
        BenhNhanRepo _repo = new BenhNhanRepo();

        public List<Benhnhan> GetAll() { return _repo.GetAll(); }

        public Benhnhan? Get(string id)
        {
            return _repo.Get(id);
        }
        public void Add(Benhnhan benhnhan)
        {
            _repo.Create(benhnhan);
        }

        public void Update(Benhnhan benhnhan)
        {
            _repo.Update(benhnhan);
        }

        public void Delete(string id)
        {
            _repo.Delete(id);
        }

        public List<Benhnhan> Search(string id)
        {
            return _repo.GetAll().Where(x => x.MaBn.ToLower().Equals(id.ToLower())).ToList();
        }

        public string GenerateMaBN()
        {
            var newestID = _repo.GetAll().OrderByDescending(x => x.MaBn).FirstOrDefault()?.MaBn;
            var newID = "";

            if (string.IsNullOrEmpty(newestID))
            {
                newID = "BN001";
            }
            else
            {
                int number = int.Parse(newestID.Substring(2)) + 1;
                newID = "BN" + number.ToString("D3");
            }
            return newID;
        }

        public string? getMaBNBySDT(string SDT)
        {
            return GetAll().FirstOrDefault(x => x.Sdt == SDT)?.MaBn;
        }
    }
}
