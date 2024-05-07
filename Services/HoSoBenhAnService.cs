using Repositories.Entities;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class HoSoBenhAnService
    {
        HoSoBenhAnRepo _repo = new HoSoBenhAnRepo();

        public List<Hosobenhan> GetAll() { return _repo.GetAll(); }

        public Hosobenhan? Get(int id)
        {
            return _repo.Get(id);
        }

        public Hosobenhan? GetByMaBN(string id)
        {
            return _repo.GetByMaBN(id);
        }

        public void Add(Hosobenhan hs)
        {
            _repo.Create(hs);
        }

        public void Update(Hosobenhan hs)
        {
            _repo.Update(hs);
        }

        public void Delete(int id)
        {
            _repo.Delete(id);
        }

        public List<Hosobenhan> SearchByMaBN(string id)
        {
            return _repo.GetAll().Where(x => x.MaBn.ToLower().Equals(id.ToLower())).ToList();
        }
    }
}
