using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ThuocRepo
    {
        PhongkhamrhmContext _context = new PhongkhamrhmContext();

        public Thuoc? Get(string username)
        {
            PhongkhamrhmContext db = new PhongkhamrhmContext();

            return db.Thuocs.FirstOrDefault(x => x.MaThuoc == username);
        }

        public Thuoc? GetByName(string name)
        {
            PhongkhamrhmContext db = new PhongkhamrhmContext();

            return db.Thuocs.FirstOrDefault(x => x.Tenthuoc == name);
        }

        public List<Thuoc> GetAll()
        {
            _context = new PhongkhamrhmContext();
            return _context.Thuocs.ToList();
        }

        public void Create(Thuoc thuoc)
        {
            _context = new PhongkhamrhmContext();
            _context.Add(thuoc);
            _context.SaveChanges();
        }

        public void Update(Thuoc thuoc)
        {
            _context = new PhongkhamrhmContext();
            _context.Update(thuoc);
            _context.SaveChanges();
        }

        public void Delete(string thuocID)
        {
            _context = new PhongkhamrhmContext();
            var thuoc = _context.Thuocs.FirstOrDefault(a => a.MaThuoc == thuocID);

            if (thuoc != null)
            {
                _context.Thuocs.Remove(thuoc);
                _context.SaveChanges();
            }
        }
    }
}
