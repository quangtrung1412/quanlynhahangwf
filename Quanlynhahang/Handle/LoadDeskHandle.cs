using Quanlynhahang.DAO.Implements;
using Quanlynhahang.Models;
using Quanlynhahang.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quanlynhahang.Handle
{
    public class LoadDeskHandle
    {
        public ListTable listTable { get; }

        public LoadDeskHandle(ListTable listTable)
        {
            this.listTable = listTable;
        }
        public void Handle()
        {
            List<Desk> list = new DeskDAO().GetAllTable();
            listTable.DisplayDeskList(list);
        }
    }
}
