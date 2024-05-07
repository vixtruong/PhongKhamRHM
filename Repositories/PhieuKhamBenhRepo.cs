using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class PhieuKhamBenhRepo
    {
        private PhongkhamrhmContext _context;

        public Phieukhambenh? Get(String id)
        {
            _context = new PhongkhamrhmContext();
            return _context.Phieukhambenhs.FirstOrDefault(x => x.MaPkb.Equals(id));
        }

        public List<Phieukhambenh> GetAll()
        {
            _context = new PhongkhamrhmContext();

            return _context.Phieukhambenhs.ToList();
        }

        public void Create(Phieukhambenh phieukhambenh)
        {
            _context = new PhongkhamrhmContext();
            _context.Phieukhambenhs.Add(phieukhambenh);
            _context.SaveChanges();
        }

        public void Update(Phieukhambenh phieukhambenh)
        {
            _context = new PhongkhamrhmContext();
            _context.Phieukhambenhs.Update(phieukhambenh);
            _context.SaveChanges();
        }

        public void Delete(string phieukhambenhID)
        {
            _context = new PhongkhamrhmContext();
            var phieukhambenh = _context.Phieukhambenhs.FirstOrDefault(x => x.MaPkb == phieukhambenhID);

            if (phieukhambenh != null)
            {
                _context.Phieukhambenhs.Remove(phieukhambenh);
                _context.SaveChanges();
            }
        }
    }
}
