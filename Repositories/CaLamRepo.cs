using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class CaLamRepo
    {
        private PhongkhamrhmContext db = new();

        public List<Calamviec> GetAll()
        {
            return db.Calamviecs.ToList();
        }

        public Calamviec? Get(string maLL)
        {
            return db.Calamviecs.FirstOrDefault(x => x.MaCa == maLL);
        }


        public void Add(Calamviec newLL)
        {
            db.Calamviecs.Add(newLL);
            db.SaveChanges();
        }

        public void Delete(string maLL)
        {
            Calamviec caLam = Get(maLL);
            if (caLam != null)
            {
                db.Calamviecs.Remove(caLam);
                db.SaveChanges();
            }
        }

        public void Update(Calamviec caLam)
        {
            db.Calamviecs.Update(caLam);
            db.SaveChanges();
        }
    }
}
