using Quanlynhahang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quanlynhahang.DAO.Implements
{
    public class AccountDAO : IAccountDAO
    {
        private QuanLyNhaHangEntities db;

        public AccountDAO()
        {
            this.db = new QuanLyNhaHangEntities();
        }
        public Account GetAccountByLoginInfo(string email, string password)
        {
            Account acc = null;
            var resultSet = db.Usp_GetAccountByLoginInfo(email, password).ToList();
            if(resultSet.Count > 0)
            {
                acc = new Account();
                foreach(var u in resultSet)
                {
                    acc.Id = u.Id;
                    acc.Name = u.Name;
                    acc.Email = u.Email;
                    acc.Pass = u.Pass;
                    acc.Rights = u.Rights;
                    acc.Avatar = u.Avatar;
                }
            }
            return acc;
        }
    }
}
