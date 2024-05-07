using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class CTVLTHRepo
    {
        private PhongkhamrhmContext _context;

        public List<Chitietvatlieutieuhao> GetAll()
        {
            _context = new PhongkhamrhmContext();

            return _context.Chitietvatlieutieuhaos.ToList();
        }

        public void Create(Chitietvatlieutieuhao benhnhan)
        {
            _context = new PhongkhamrhmContext();
            _context.Chitietvatlieutieuhaos.Add(benhnhan);
            _context.SaveChanges();
        }

        public void Update(Chitietvatlieutieuhao benhnhan)
        {
            _context = new PhongkhamrhmContext();
            _context.Chitietvatlieutieuhaos.Update(benhnhan);
            _context.SaveChanges();
        }

        public void Delete(int benhnhanID)
        {
            _context = new PhongkhamrhmContext();
            var benhnhan = _context.Chitietvatlieutieuhaos.FirstOrDefault(x => x.Id == benhnhanID);

            if (benhnhan != null)
            {
                _context.Chitietvatlieutieuhaos.Remove(benhnhan);
                _context.SaveChanges();
            }
        }
    }
}
