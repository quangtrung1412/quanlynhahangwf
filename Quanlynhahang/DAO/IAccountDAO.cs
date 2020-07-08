using Quanlynhahang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quanlynhahang.DAO
{
    public interface IAccountDAO
    {
        Account GetAccountByLoginInfo(string email, string password);
    }
}
