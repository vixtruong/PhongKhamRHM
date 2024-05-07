using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CTToaThuocService
    {
        CTToathuocRepo _repo = new CTToathuocRepo();

        public List<Chitiettoathuoc> GetAll() { return _repo.GetAll(); }

        public Chitiettoathuoc? GetToathuoc(int id)
        {
            return _repo.Get(id);
        }
        public void AddToa(Chitiettoathuoc ctttoathuoc)
        {
            _repo.Create(ctttoathuoc);
        }

        public void UpdateToa(Chitiettoathuoc ctttoathuoc)
        {
            _repo.Update(ctttoathuoc);
        }

        public void DeleteToa(int toaId)
        {
            _repo.Delete(toaId);
        }
    }
}
