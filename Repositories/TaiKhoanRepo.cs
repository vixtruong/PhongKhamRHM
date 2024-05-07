using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class TaiKhoanRepo
    {
        private PhongkhamrhmContext _context;

        public Taikhoan? Get(string username) {
            PhongkhamrhmContext db = new PhongkhamrhmContext();

            return db.Taikhoans.FirstOrDefault(x => x.Sdt == username);
        }

        public List<Taikhoan> GetAll()
        {
            _context = new PhongkhamrhmContext();
            return _context.Taikhoans.ToList();
        }

        public void Create(Taikhoan account)
        {
            _context = new PhongkhamrhmContext();
            _context.Add(account);
            _context.SaveChanges();
        }

        public void Update(Taikhoan account)
        {
            _context = new PhongkhamrhmContext();
            _context.Update(account);
            _context.SaveChanges();
        }

        public void Delete(string username)
        {
            _context = new PhongkhamrhmContext();
            var account = _context.Taikhoans.FirstOrDefault(a => a.Sdt == username);

            if (account != null)
            {
                _context.Taikhoans.Remove(account);
                _context.SaveChanges();
            }
        }
    }
}
