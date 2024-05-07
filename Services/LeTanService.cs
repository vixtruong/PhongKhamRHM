using Microsoft.EntityFrameworkCore;
using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class LeTanService
    {
        private LeTanRepo _repo = new LeTanRepo();

        public List<Letan> GetAll() { return _repo.GetAll(); }

        public Letan? GetLetan(string id)
        {
            return _repo.Get(id);
        }

        public Letan? GetByPhone(string sdt)
        {
            return _repo.GetByPhone(sdt);
        }
        public void AddLeTan(Letan letan)
        {
            _repo.Create(letan);
        }

        public void UpdateLeTan(Letan letan)
        {
            _repo.Update(letan);
        }

        public void DeleteLeTan(string ltId)
        {
            _repo.Delete(ltId);
        }

        public List<Letan> SearchLeTan(string id)
        {
            return _repo.GetAll().Where(x => x.MaLt.ToLower().Equals(id.ToLower())).ToList();
        }

        public string GenerateLeTanID()
        { 
            var newestID = _repo.GetAll().OrderByDescending(x => x.MaLt).FirstOrDefault()?.MaLt;
            var newID = "";

            if (string.IsNullOrEmpty(newestID))
            {
                newID = "LT001";
            }
            else
            {
                int number = int.Parse(newestID.Substring(2)) + 1;
                newID = "LT" + number.ToString("D3");
            }
            return newID;
        }
    }
}
