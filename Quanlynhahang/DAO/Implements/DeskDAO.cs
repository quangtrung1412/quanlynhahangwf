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
            throw new NotImplementedException();
        }

        public List<Desk> GetAllTable()
        {
            List<Desk> ld = new List<Desk>();
            var resultSet = db.Usp_GetAllDesk().ToList();
            if (resultSet.Count > 0)
            {
                Desk d;
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
            throw new NotImplementedException();
        }

        public bool UpdateDesk(Desk d)
        {
            throw new NotImplementedException();
        }
    }
}
