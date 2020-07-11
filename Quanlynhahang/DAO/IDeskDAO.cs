using Quanlynhahang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quanlynhahang.DAO
{
    public interface IDeskDAO
    {
        List<Desk> GetAllTable();
        bool InsertDesk(Desk d);
        bool DeleteDesk(string id);
        bool UpdateDesk(Desk d);
    }
}
