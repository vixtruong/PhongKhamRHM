using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class CTPkbRepo
    {
        PhongkhamrhmContext _context = new PhongkhamrhmContext();

        public Chitietpkb? Get(int id)
        {
            return _context.Chitietpkbs.FirstOrDefault(x => x.MaCtpkb == id);
        }

        public Chitietpkb? GetByPkbID(string id)
        {
            return _context.Chitietpkbs.FirstOrDefault(x => x.MaPkb == id);
        }

        public List<Chitietpkb> GetAll()
        {
            _context = new PhongkhamrhmContext();
            return _context.Chitietpkbs.ToList();
        }

        public void Create(Chitietpkb ctpkb)
        {
            _context = new PhongkhamrhmContext();
            _context.Add(ctpkb);
            _context.SaveChanges();
        }

        public void Update(Chitietpkb ctpkb)
        {
            _context = new PhongkhamrhmContext();
            _context.Update(ctpkb);
            _context.SaveChanges();
        }

        public void Delete(int ctpkbID)
        {
            _context = new PhongkhamrhmContext();
            var ctpkb = _context.Chitietpkbs.FirstOrDefault(a => a.MaCtpkb == ctpkbID);

            if (ctpkb != null)
            {
                _context.Chitietpkbs.Remove(ctpkb);
                _context.SaveChanges();
            }
        }
    }
}
