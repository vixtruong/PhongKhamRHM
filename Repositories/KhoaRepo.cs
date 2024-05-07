using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class KhoaRepo
    {
        private PhongkhamrhmContext _context;

        public Khoa? Get(string id)
        {
            PhongkhamrhmContext db = new PhongkhamrhmContext();

            return db.Khoas.FirstOrDefault(x => x.MaKhoa.Equals(id));
        }

        public Khoa? GetByName(string name)
        {
            PhongkhamrhmContext db = new PhongkhamrhmContext();

            return db.Khoas.FirstOrDefault(x => x.TenKhoa.Equals(name));
        }

        public List<Khoa> GetAll()
        {
            _context = new PhongkhamrhmContext();

            return _context.Khoas.ToList();
        }

        public void Create(Khoa khoa)
        {
            _context = new PhongkhamrhmContext();
            _context.Khoas.Add(khoa);
            _context.SaveChanges();
        }

        public void Update(Khoa khoa)
        {
            _context = new PhongkhamrhmContext();
            _context.Khoas.Update(khoa);
            _context.SaveChanges();
        }

        public void Delete(string ID)
        {
            _context = new PhongkhamrhmContext();
            var khoa = _context.Khoas.FirstOrDefault(x => x.MaKhoa == ID);

            if (khoa != null)
            {
                _context.Khoas.Remove(khoa);
                _context.SaveChanges();
            }
        }
    }
}
