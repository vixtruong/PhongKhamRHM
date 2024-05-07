using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class BenhNhanRepo
    {
        private PhongkhamrhmContext _context;

        public Benhnhan? Get(string id)
        {
            PhongkhamrhmContext db = new PhongkhamrhmContext();

            return db.Benhnhans.FirstOrDefault(x => x.MaBn.Equals(id));
        }

        public Benhnhan? GetBySDT(string sdt)
        {
            PhongkhamrhmContext db = new PhongkhamrhmContext();

            return db.Benhnhans.FirstOrDefault(x => x.Sdt.Trim().Equals(sdt.Trim()));
        }

        public List<Benhnhan> GetAll()
        {
            _context = new PhongkhamrhmContext();

            return _context.Benhnhans.ToList();
        }

        public void Create(Benhnhan benhnhan)
        {
            _context = new PhongkhamrhmContext();
            _context.Benhnhans.Add(benhnhan);
            _context.SaveChanges();
        }

        public void Update(Benhnhan benhnhan)
        {
            _context = new PhongkhamrhmContext();
            _context.Benhnhans.Update(benhnhan);
            _context.SaveChanges();
        }

        public void Delete(string benhnhanID)
        {
            _context = new PhongkhamrhmContext();
            var benhnhan = _context.Benhnhans.FirstOrDefault(x => x.MaBn == benhnhanID);

            if (benhnhan != null)
            {
                _context.Benhnhans.Remove(benhnhan);
                _context.SaveChanges();
            }
        }
    }
}
