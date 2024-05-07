using Microsoft.EntityFrameworkCore.Infrastructure;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class LeTanRepo
    {
        private PhongkhamrhmContext _context;

        public Letan? Get(string id)
        {
            _context = new PhongkhamrhmContext();
            return _context.Letans.FirstOrDefault(x => x.MaLt.Equals(id));
        }

        public Letan? GetByPhone(string sdt)
        {
            _context = new PhongkhamrhmContext();
            return _context.Letans.FirstOrDefault(x => x.Sdt.Equals(sdt));
        }

        public List<Letan> GetAll()
        {
            _context = new PhongkhamrhmContext();

            return _context.Letans.ToList();
        }

        public void Create(Letan letan)
        {
            _context = new PhongkhamrhmContext();
            _context.Letans.Add(letan);
            _context.SaveChanges();
        }

        public void Update(Letan letan) {
            _context = new PhongkhamrhmContext();
            _context.Letans.Update(letan);
            _context.SaveChanges();
        }

        public void Delete(string letanID)
        {
            _context = new PhongkhamrhmContext();
            var letan = _context.Letans.FirstOrDefault(x => x.MaLt == letanID);
            
            if (letan != null)
            {
                _context.Letans.Remove(letan);
                _context.SaveChanges();
            }
        }
    }
}
