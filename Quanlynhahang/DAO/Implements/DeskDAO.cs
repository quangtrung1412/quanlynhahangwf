using Quanlynhahang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quanlynhahang.DAO.Implements
{
    public class DeskDAO : IDeskDAO
    {
        private QuanLyNhaHangEntities db;
        public DeskDAO()
        {
            this.db = new QuanLyNhaHangEntities();
        }
        public bool DeleteDesk(string id)
        {
            int i = db.Usp_DeleteDesk(id);
            if (i == 1)
            {
                return true;
            }
            return false;

        }

        public List<Desk> GetAllTable()
        {
            List<Desk> ld = new List<Desk>();
            var resultSet = db.Usp_GetAllDesk().ToList();
            if (resultSet.Count > 0)
            {
                Desk d = new Desk();
                foreach(var u in resultSet)
                {
                    d = new Desk();
                    d.Id = u.Id;
                    d.Name = u.Name;
                    d.Status = u.Status;
                    ld.Add(d);
                }
            }
            return ld;
        }

        public bool InsertDesk(Desk d)
        {
            int i = db.Usp_InsertDesk(d.Id,d.Name,d.Status);
            if (i == 1)
            {
                return true;
            }
            return false;
        }

        public bool UpdateDesk(Desk d)
        {
            int i = db.Usp_InsertDesk(d.Id, d.Name, d.Status);
            if (i == 1)
            {
                return true;
            }
            return false;
        }
    }
}
