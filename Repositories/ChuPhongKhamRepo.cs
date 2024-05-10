using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ChuPhongKhamRepo
    {
        private PhongkhamrhmContext _context;

        public Chuphongkham? Get(string id)
        {
            PhongkhamrhmContext db = new PhongkhamrhmContext();

            return db.Chuphongkhams.FirstOrDefault(x => x.MaCpk.Equals(id));
        }

        public Chuphongkham? GetByPhone(string sdt)
        {
            PhongkhamrhmContext db = new PhongkhamrhmContext();

            return db.Chuphongkhams.FirstOrDefault(x => x.Sdt.Equals(sdt));
        }

        public List<Chuphongkham> GetAll()
        {
            _context = new PhongkhamrhmContext();

            return _context.Chuphongkhams.ToList();
        }

        public void Create(Chuphongkham chuphongkham)
        {
            _context = new PhongkhamrhmContext();
            _context.Chuphongkhams.Add(chuphongkham);
            _context.SaveChanges();
        }

        public void Update(Chuphongkham chuphongkham)
        {
            _context = new PhongkhamrhmContext();
            _context.Chuphongkhams.Update(chuphongkham);
            _context.SaveChanges();
        }

        public void Delete(string chuphongkhamID)
        {
            _context = new PhongkhamrhmContext();
            var chuphongkham = _context.Chuphongkhams.FirstOrDefault(x => x.MaCpk == chuphongkhamID);

            if (chuphongkham != null)
            {
                _context.Chuphongkhams.Remove(chuphongkham);
                _context.SaveChanges();
            }
        }
    }
}
