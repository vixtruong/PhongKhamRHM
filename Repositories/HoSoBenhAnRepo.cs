using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class HoSoBenhAnRepo
    {
        private PhongkhamrhmContext _context;

        public Hosobenhan? Get(int id)
        {
            PhongkhamrhmContext db = new PhongkhamrhmContext();

            return db.Hosobenhans.FirstOrDefault(x => x.MaHs == id);
        }

        public Hosobenhan? GetByMaBN(string id)
        {
            PhongkhamrhmContext db = new PhongkhamrhmContext();

            return db.Hosobenhans.FirstOrDefault(x => x.MaBn.Equals(id));
        }

        public List<Hosobenhan> GetAll()
        {
            _context = new PhongkhamrhmContext();

            return _context.Hosobenhans.ToList();
        }

        public void Create(Hosobenhan hs)
        {
            _context = new PhongkhamrhmContext();
            _context.Hosobenhans.Add(hs);
            _context.SaveChanges();
        }

        public void Update(Hosobenhan hs)
        {
            _context = new PhongkhamrhmContext();
            _context.Hosobenhans.Update(hs);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            _context = new PhongkhamrhmContext();
            var bacsi = _context.Hosobenhans.FirstOrDefault(x => x.MaHs == id);

            if (bacsi != null)
            {
                _context.Hosobenhans.Remove(bacsi);
                _context.SaveChanges();
            }
        }
    }
}
