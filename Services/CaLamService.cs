using Repositories.Entities;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CaLamService
    {
        private CaLamRepo _repo = new();
        public List<Calamviec> GetAll()
        {
            return _repo.GetAll();
        }
        public Calamviec? Get(string maLL)
        {
            return _repo.Get(maLL);
        }

        public void Add(Calamviec newLL)
        {
            _repo.Add(newLL);
        }

        public void Update(Calamviec updatedCalam)
        {
            _repo.Update(updatedCalam);
        }

        public void Delete(string maLL)
        {
            _repo.Delete(maLL);
        }
        public string GenerateMaLL()
        {
            List<Calamviec> Calams = GetAll();
            if (Calams.Count == 0) return "LL001";
            int nextSTT = int.Parse(Calams.Last().MaCa.Substring(2, 3)) + 1;
            if (nextSTT < 10) return "LL00" + nextSTT;
            if (nextSTT < 100) return "LLH0" + nextSTT;
            if (nextSTT < 1000) return "LL" + nextSTT;
            return "maximum";
        }

        public List<string> GetAllMaBS(DateTime date)
        {
            List<string> result = new();

            List<Calamviec> list = GetAll();
            foreach (var lich in list)
            {
                if (lich.Ngay == DateOnly.FromDateTime(date))
                    result.Add(lich.MaBs);
            }

            return result;
        }
    }
}
