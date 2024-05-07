using Repositories.Entities;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CTPkbService
    {
        CTPkbRepo _repo = new CTPkbRepo();

        public List<Chitietpkb> GetAll() { return _repo.GetAll(); }

        public Chitietpkb? Get(int id)
        {
            return _repo.Get(id);
        }

        public Chitietpkb? GetByPkbID(string id)
        {
            return _repo.GetByPkbID(id);
        }

        public void Add(Chitietpkb ctpkb)
        {
            _repo.Create(ctpkb);
        }

        public void Update(Chitietpkb ctpkb)
        {
            _repo.Update(ctpkb);
        }

        public void Delete(int toaId)
        {
            _repo.Delete(toaId);
        }
    }
}
