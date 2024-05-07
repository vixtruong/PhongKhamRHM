using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class KyThuatRepo
    {
        PhongkhamrhmContext _context = new PhongkhamrhmContext();

        public Kythuat? Get(string id)
        {
            return _context.Kythuats.FirstOrDefault(x => x.MaKt == id);
        }

        public Kythuat? GetByName(string name)
        {
            return _context.Kythuats.FirstOrDefault(x => x.TenKt == name);
        }

        public List<Kythuat> GetAll()
        {
            _context = new PhongkhamrhmContext();
            return _context.Kythuats.ToList();
        }

        public void Create(Kythuat kythuat)
        {
            _context = new PhongkhamrhmContext();
            _context.Add(kythuat);
            _context.SaveChanges();
        }

        public void Update(Kythuat kythuat)
        {
            _context = new PhongkhamrhmContext();
            _context.Update(kythuat);
            _context.SaveChanges();
        }

        public void Delete(string ktID)
        {
            _context = new PhongkhamrhmContext();
            var kythuat = _context.Kythuats.FirstOrDefault(a => a.MaKt == ktID);

            if (kythuat != null)
            {
                _context.Kythuats.Remove(kythuat);
                _context.SaveChanges();
            }
        }
    }
}
