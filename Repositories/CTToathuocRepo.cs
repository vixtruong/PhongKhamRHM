using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class CTToathuocRepo
    {
        PhongkhamrhmContext _context = new PhongkhamrhmContext();

        public Chitiettoathuoc? Get(int id)
        {
            PhongkhamrhmContext db = new PhongkhamrhmContext();

            return db.Chitiettoathuocs.FirstOrDefault(x => x.Macttt == id);
        }

        public List<Chitiettoathuoc> GetAll()
        {
            _context = new PhongkhamrhmContext();
            return _context.Chitiettoathuocs.ToList();
        }

        public void Create(Chitiettoathuoc cttoathuoc)
        {
            _context = new PhongkhamrhmContext();
            _context.Add(cttoathuoc);
            _context.SaveChanges();
        }

        public void Update(Chitiettoathuoc cttoathuoc)
        {
            _context = new PhongkhamrhmContext();
            _context.Update(cttoathuoc);
            _context.SaveChanges();
        }

        public void Delete(int ctToaID)
        {
            _context = new PhongkhamrhmContext();
            var cttoathuoc = _context.Chitiettoathuocs.FirstOrDefault(a => a.Macttt == ctToaID);

            if (cttoathuoc != null)
            {
                _context.Chitiettoathuocs.Remove(cttoathuoc);
                _context.SaveChanges();
            }
        }
    }
}
