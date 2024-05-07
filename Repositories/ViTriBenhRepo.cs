using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ViTriBenhRepo
    {
        PhongkhamrhmContext _context = new PhongkhamrhmContext();

        public Vitribenh? Get(string id)
        {
            return _context.Vitribenhs.FirstOrDefault(x => x.MaVt == id);
        }

        public Vitribenh? GetByKTIdAndName(string KTId, string name)
        {
            return _context.Vitribenhs.FirstOrDefault(x => x.MaKt == KTId && x.TenVt == name);
        }

        public List<Vitribenh> GetAll()
        {
            _context = new PhongkhamrhmContext();
            return _context.Vitribenhs.ToList();
        }

        public void Create(Vitribenh kythuat)
        {
            _context = new PhongkhamrhmContext();
            _context.Add(kythuat);
            _context.SaveChanges();
        }

        public void Update(Vitribenh kythuat)
        {
            _context = new PhongkhamrhmContext();
            _context.Update(kythuat);
            _context.SaveChanges();
        }

        public void Delete(string ktID)
        {
            _context = new PhongkhamrhmContext();
            var vitribenh = _context.Vitribenhs.FirstOrDefault(a => a.MaVt == ktID);

            if (vitribenh != null)
            {
                _context.Vitribenhs.Remove(vitribenh);
                _context.SaveChanges();
            }
        }
    }
}
