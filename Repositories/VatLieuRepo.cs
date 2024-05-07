using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class VatLieuRepo
    {
        PhongkhamrhmContext _context = new PhongkhamrhmContext();

        public Vatlieu? Get(string id)
        {
            PhongkhamrhmContext db = new PhongkhamrhmContext();

            return db.Vatlieus.FirstOrDefault(x => x.MaVl == id);
        }

        public Vatlieu? GetByName(string name)
        {
            PhongkhamrhmContext db = new PhongkhamrhmContext();

            return db.Vatlieus.FirstOrDefault(x => x.TenVl == name);
        }

        public Vatlieu? GetByKhoaAndName(string makhoa, string name)
        {
            PhongkhamrhmContext db = new PhongkhamrhmContext();

            return db.Vatlieus.FirstOrDefault(x => x.TenVl == name && x.MaKhoa == makhoa);
        }

        public List<Vatlieu> GetAll()
        {
            _context = new PhongkhamrhmContext();
            return _context.Vatlieus.ToList();
        }

        public void Create(Vatlieu kythuat)
        {
            _context = new PhongkhamrhmContext();
            _context.Add(kythuat);
            _context.SaveChanges();
        }

        public void Update(Vatlieu kythuat)
        {
            _context = new PhongkhamrhmContext();
            _context.Update(kythuat);
            _context.SaveChanges();
        }

        public void Delete(string ktID)
        {
            _context = new PhongkhamrhmContext();
            var vatlieu = _context.Vatlieus.FirstOrDefault(a => a.MaVl == ktID);

            if (vatlieu != null)
            {
                _context.Vatlieus.Remove(vatlieu);
                _context.SaveChanges();
            }
        }
    }
}
