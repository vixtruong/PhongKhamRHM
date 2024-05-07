using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class PhuTaRepo
    {
        private PhongkhamrhmContext _context;

        public Phuta? Get(string id)
        {
            PhongkhamrhmContext db = new PhongkhamrhmContext();

            return db.Phutas.FirstOrDefault(x => x.MaPt.Equals(id));
        }
        public List<Phuta> GetAll()
        {
            _context = new PhongkhamrhmContext();

            return _context.Phutas.ToList();
        }

        public void Create(Phuta phuta)
        {
            _context = new PhongkhamrhmContext();
            _context.Phutas.Add(phuta);
            _context.SaveChanges();
        }

        public void Update(Phuta phuta)
        {
            _context = new PhongkhamrhmContext();
            _context.Phutas.Update(phuta);
            _context.SaveChanges();
        }

        public void Delete(string phutaID)
        {
            _context = new PhongkhamrhmContext();
            var phuta = _context.Phutas.FirstOrDefault(x => x.MaPt == phutaID);

            if (phuta != null)
            {
                _context.Phutas.Remove(phuta);
                _context.SaveChanges();
            }
        }
    }
}
