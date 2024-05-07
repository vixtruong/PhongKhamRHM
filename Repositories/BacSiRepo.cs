using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class BacSiRepo
    {
        private PhongkhamrhmContext _context;

        public Bacsi? Get(string id)
        {
            PhongkhamrhmContext db = new PhongkhamrhmContext();

            return db.Bacsis.FirstOrDefault(x => x.MaBs.Equals(id));
        }

        public Bacsi? GetByPhone(string sdt)
        {
            PhongkhamrhmContext db = new PhongkhamrhmContext();

            return db.Bacsis.FirstOrDefault(x => x.Sdt.Equals(sdt));
        }

        public List<Bacsi> GetAll()
        {
            _context = new PhongkhamrhmContext();

            return _context.Bacsis.ToList();
        }

        public void Create(Bacsi bacsi)
        {
            _context = new PhongkhamrhmContext();
            _context.Bacsis.Add(bacsi);
            _context.SaveChanges();
        }

        public void Update(Bacsi bacsi)
        {
            _context = new PhongkhamrhmContext();
            _context.Bacsis.Update(bacsi);
            _context.SaveChanges();
        }

        public void Delete(string bacsiID)
        {
            _context = new PhongkhamrhmContext();
            var bacsi = _context.Bacsis.FirstOrDefault(x => x.MaBs == bacsiID);

            if (bacsi != null)
            {
                _context.Bacsis.Remove(bacsi);
                _context.SaveChanges();
            }
        }
    }
}
