using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class KyThuatService
    {
        KyThuatRepo _repo = new KyThuatRepo();

        public List<Kythuat> GetAll() { return _repo.GetAll(); }

        public Kythuat? GetKythuat(string id)
        {
            return _repo.Get(id);
        }

        public Kythuat? GetByName(string name)
        {
            return _repo.GetByName(name);
        }
        public void AddKythuat(Kythuat kythuat)
        {
            _repo.Create(kythuat);
        }

        public void UpdateKythuat(Kythuat kythuat)
        {
            _repo.Update(kythuat);
        }

        public void DeleteKythuat(string ltId)
        {
            _repo.Delete(ltId);
        }

        public List<Kythuat> SearchKyThuat(string id)
        {
            return _repo.GetAll().Where(x => x.MaKt.ToLower().Equals(id.ToLower())).ToList();
        }

        public string GenerateKyThuatID()
        {
            var newestID = _repo.GetAll().OrderByDescending(x => x.MaKt).FirstOrDefault()?.MaKt;
            var newID = "";

            if (string.IsNullOrEmpty(newestID))
            {
                newID = "KT001";
            }
            else
            {
                int number = int.Parse(newestID.Substring(2)) + 1;
                newID = "KT" + number.ToString("D3");
            }
            return newID;
        }
    }
}
