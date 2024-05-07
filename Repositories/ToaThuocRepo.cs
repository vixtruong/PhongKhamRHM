using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ToaThuocRepo
    {
        private PhongkhamrhmContext _context;

        public Toathuoc? Get(String id)
        {
            _context = new PhongkhamrhmContext();
            return _context.Toathuocs.FirstOrDefault(x => x.MaToa.Equals(id));
        }

        public Toathuoc? GetByPkbID(string id) {
            _context = new PhongkhamrhmContext();
            return _context.Toathuocs.FirstOrDefault(x => x.MaPkb.Equals(id));
        }

        public List<Toathuoc> GetAll()
        {
            _context = new PhongkhamrhmContext();

            return _context.Toathuocs.ToList();
        }

        public void Create(Toathuoc toathuoc)
        {
            _context = new PhongkhamrhmContext();
            _context.Toathuocs.Add(toathuoc);
            _context.SaveChanges();
        }

        public void Update(Toathuoc toathuoc)
        {
            _context = new PhongkhamrhmContext();
            _context.Toathuocs.Update(toathuoc);
            _context.SaveChanges();
        }

        public void Delete(string toathuocID)
        {
            _context = new PhongkhamrhmContext();
            var toathuoc = _context.Toathuocs.FirstOrDefault(x => x.MaToa == toathuocID);

            if (toathuoc != null)
            {
                _context.Toathuocs.Remove(toathuoc);
                _context.SaveChanges();
            }
        }
    }
}
