using Repositories.Entities;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class VatLieuService
    {
        VatLieuRepo _repo = new VatLieuRepo();

        public List<Vatlieu> GetAll() { return _repo.GetAll(); }

        public Vatlieu GetKythuat(string id)
        {
            return _repo.Get(id);
        }

        public Vatlieu GetByName(string name)
        {
            return _repo.GetByName(name);
        }

        public Vatlieu? GetByKhoaAndName(string makhoa, string name)
        {
            return _repo.GetByKhoaAndName(makhoa, name);
        }

        public void Add(Vatlieu vatlieu)
        {
            _repo.Create(vatlieu);
        }

        public void Update(Vatlieu vatlieu)
        {
            _repo.Update(vatlieu);
        }

        public void Delete(string ltId)
        {
            _repo.Delete(ltId);
        }

        public List<Vatlieu> Search(string id)
        {
            return _repo.GetAll().Where(x => x.MaVl.ToLower().Equals(id.ToLower())).ToList();
        }

        public string GenerateID()
        {
            var newestID = _repo.GetAll().OrderByDescending(x => x.MaVl).FirstOrDefault()?.MaVl;
            var newID = "";

            if (string.IsNullOrEmpty(newestID))
            {
                newID = "VL001";
            }
            else
            {
                int number = int.Parse(newestID.Substring(2)) + 1;
                newID = "VL" + number.ToString("D3");
            }
            return newID;
        }
    }
}
