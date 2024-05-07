using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class TaiKhoanService
    {
        private TaiKhoanRepo _repo = new TaiKhoanRepo();

        public Taikhoan? Get(string sdt) { return _repo.Get(sdt);}

        public Taikhoan? CheckLogin(string username, string password)
        {
            TaiKhoanRepo repo = new TaiKhoanRepo();

            Taikhoan account = repo.Get(username);
            if (account == null)
                return null;
            if (account.Matkhau == password)
                return account;
            return null;
        }

        public Taikhoan? CheckSignUp(string username)
        {
            TaiKhoanRepo repo = new TaiKhoanRepo();
            Taikhoan account = repo.Get(username);

            if (account == null) return null;
            return account;
        }

        public List<Taikhoan> GetAllTaiKhoans()
        {
            return _repo.GetAll();
        }

        public void AddTaiKhoan(Taikhoan account)
        {
            _repo.Create(account);
        }

        public void UpdateTaiKhoan(Taikhoan account)
        {
            _repo.Update(account);
        }

        public void DeleteTaiKhoan(string username)
        {
            _repo.Delete(username);
        }
    }
}
