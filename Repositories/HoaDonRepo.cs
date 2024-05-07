using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class HoaDonRepo
    {
        private PhongkhamrhmContext _context;

        public Hoadon? Get(string id)
        {
            _context = new PhongkhamrhmContext();
            return _context.Hoadons.FirstOrDefault(x => x.MaHd.Equals(id));
        }
        public List<Hoadon> GetAll()
        {
            _context = new PhongkhamrhmContext();
            return _context.Hoadons.ToList();
        }

        public void Create(Hoadon hoadon)
        {
            _context = new PhongkhamrhmContext();
            _context.Hoadons.Add(hoadon);
            _context.SaveChanges();
        }

        public void Update(Hoadon hoadon)
        {
            _context = new PhongkhamrhmContext();
            _context.Hoadons.Update(hoadon);
            _context.SaveChanges();
        }

        public void Delete(string bacsiID)
        {
            _context = new PhongkhamrhmContext();
            var hoadon = _context.Hoadons.FirstOrDefault(x => x.MaHd == bacsiID);

            if (hoadon != null)
            {
                _context.Hoadons.Remove(hoadon);
                _context.SaveChanges();
            }
        }
    }
}
