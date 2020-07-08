using Microsoft.VisualBasic.ApplicationServices;
using Quanlynhahang.DAO.Implements;
using Quanlynhahang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quanlynhahang.Handle
{
    public class LoginHandle
    {
        
        private Login login;

        public LoginHandle(Login login)
        {
            this.login = login;
        }
        public void Handle(string email, string password)
        {
            //string regexEmail = "^[\\w!#$%&'*+/=?`{|}~^-]+(?:\\.[\\w!#$%&'*+/=?`{|}~^-]+)*@(?!-)(?:[a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$";
            if(email.Equals("") || password.Equals(""))
            {
                login.ShowErrorLogin();
            } else
            {
                Account acc = new AccountDAO().GetAccountByLoginInfo(email, password);
                if(acc!=null)
                {
                    login.InitMainForm(acc);
                }else
                {
                    login.ShowErrorLoginInfo();
                }
            }
        }
    }
}
