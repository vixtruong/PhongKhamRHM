using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class LichHenRepo
    {
        private PhongkhamrhmContext db = new();

        public List<Lichhen>? GetAll()
        {
            return db.Lichhens.ToList();
        }

        public Lichhen? Get(string maLH)
        {
            return db.Lichhens.Find(maLH);
        }


        public void Add(Lichhen newLH)
        {
            db.Lichhens.Add(newLH);
            db.SaveChanges();
        }

        public void Delete(string maLH)
        {
            Lichhen lichHen = Get(maLH);
            if (lichHen != null)
            {
                db.Lichhens.Remove(lichHen);
                db.SaveChanges();
            }
        }

        public void Update(Lichhen lichHen)
        {
            db.Lichhens.Update(lichHen);
            db.SaveChanges();
        }
    }
}
