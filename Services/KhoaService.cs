using Repositories.Entities;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class KhoaService
    {
        KhoaRepo _repo = new KhoaRepo();

        public List<Khoa> GetAll() { return _repo.GetAll(); }

        public Khoa? Get(string id)
        {
            return _repo.Get(id);
        }

        public Khoa? GetByName(string name)
        {
            return _repo.GetByName(name);
        }

        public void Add(Khoa benhnhan)
        {
            _repo.Create(benhnhan);
        }

        public void Update(Khoa benhnhan)
        {
            _repo.Update(benhnhan);
        }

        public void Delete(string id)
        {
            _repo.Delete(id);
        }

        public List<Khoa> Search(string id)
        {
            return _repo.GetAll().Where(x => x.MaKhoa.ToLower().Equals(id.ToLower())).ToList();
        }

        public bool isExist(string makhoa)
        {
            return _repo.GetAll().FirstOrDefault(x => x.MaKhoa == makhoa) != null;
        }
    }
}
