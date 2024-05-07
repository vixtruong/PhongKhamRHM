using Repositories.Entities;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ViTriBenhService
    {
        ViTriBenhRepo _repo = new ViTriBenhRepo();

        public List<Vitribenh> GetAll() { return _repo.GetAll(); }

        public Vitribenh? Get(string id)
        {
            return _repo.Get(id);
        }

        public Vitribenh? GetByKTIdAndName(string KTId, string name)
        {
            return _repo.GetByKTIdAndName(KTId, name);
        }

        public void Add(Vitribenh vitribenh)
        {
            _repo.Create(vitribenh);
        }

        public void Update(Vitribenh vitribenh)
        {
            _repo.Update(vitribenh);
        }

        public void Delete(string ltId)
        {
            _repo.Delete(ltId);
        }

        public List<Vitribenh> Search(string id)
        {
            return _repo.GetAll().Where(x => x.MaVt.ToLower().Equals(id.ToLower())).ToList();
        }

        public string GenerateID()
        {
            var newestID = _repo.GetAll().OrderByDescending(x => x.MaVt).FirstOrDefault()?.MaVt;
            var newID = "";

            if (string.IsNullOrEmpty(newestID))
            {
                newID = "VT001";
            }
            else
            {
                int number = int.Parse(newestID.Substring(2)) + 1;
                newID = "VT" + number.ToString("D3");
            }
            return newID;
        }
    }
}
