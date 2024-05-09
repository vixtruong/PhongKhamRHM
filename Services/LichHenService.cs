using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class LichHenService
    {

        private LichHenRepo _repo = new();

        public List<Lichhen>? GetAll()
        {
            return _repo.GetAll();
        }
        public Lichhen? Get(string maHD)
        {
            return _repo.Get(maHD);
        }

        public void Add(Lichhen newLichhen)
        {
            _repo.Add(newLichhen);
        }

        public void Update(Lichhen updatedLichhen)
        {
            _repo.Update(updatedLichhen);
        }

        public void Delete(string maHD)
        {
            _repo.Delete(maHD);
        }
        public string GenerateMaLH()
        {
            List<Lichhen> Lichhens = GetAll();
            if (Lichhens.Count == 0) return "LH001";
            int nextSTT = int.Parse(Lichhens.Last().MaLh.Substring(2, 3)) + 1;
            if (nextSTT < 10) return "LH00" + nextSTT;
            if (nextSTT < 100) return "LH0" + nextSTT;
            if (nextSTT < 1000) return "LH" + nextSTT;
            return "maximum";
        }
    }
}
