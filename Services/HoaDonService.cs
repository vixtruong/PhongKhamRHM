using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class HoaDonService
    {
        HoaDonRepo _repo = new HoaDonRepo();

        public List<Hoadon> GetAll() { return _repo.GetAll(); }

        public Hoadon Get(string id)
        {
            return _repo.Get(id);
        }
        public void Add(Hoadon hoadon)
        {
            _repo.Create(hoadon);
        }

        public void Update(Hoadon hoadon)
        {
            _repo.Update(hoadon);
        }

        public void Delete(string id)
        {
            _repo.Delete(id);
        }

        public List<Hoadon> Search(string id)
        {
            return _repo.GetAll().Where(x => x.MaHd.ToLower().Equals(id.ToLower())).ToList();
        }

        public string GenerateID()
        {
            var newestID = _repo.GetAll().OrderByDescending(x => x.MaHd).FirstOrDefault()?.MaHd;
            var newID = "";

            if (string.IsNullOrEmpty(newestID))
            {
                newID = "HD001";
            }
            else
            {
                short number = (short) (int.Parse(newestID.Substring(2)) + 1);
                newID = "HD" + number.ToString("D3");
            }
            return newID;
        }

        public List<Hoadon> GetHDInRange(DateOnly dateStart, DateOnly dateEnd)
        {
            return GetAll().Where(h => h.Ngaylap >= dateStart && h.Ngaylap <= dateEnd).ToList();
        }
    }
}
