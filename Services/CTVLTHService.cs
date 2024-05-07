using Repositories.Entities;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CTVLTHService
    {
        CTVLTHRepo _repo = new CTVLTHRepo();

        public List<Chitietvatlieutieuhao> GetAll() { return _repo.GetAll(); }

        public void Add(Chitietvatlieutieuhao benhnhan)
        {
            _repo.Create(benhnhan);
        }

        public void Update(Chitietvatlieutieuhao benhnhan)
        {
            _repo.Update(benhnhan);
        }

        public void Delete(int id)
        {
            _repo.Delete(id);
        }
    }
}
