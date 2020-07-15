using Quanlynhahang.DAO.Implements;
using Quanlynhahang.Models;
using Quanlynhahang.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quanlynhahang.Handle
{
    public class GetBillByIdDeskHandle
    {
        private ListTable listTable;
        private Desk d;

        public GetBillByIdDeskHandle(ListTable listTable,Desk d)
        {
            this.listTable = listTable;
            this.d = d;
        }
        public void Handle(object sender ,EventArgs e)
        {
            int i = 0;
            List<Bill> list = new BillDAO().GetBillByDeskId(d.Id,0);
            if(list.Count > 0)
            {

            }
        }
    }
}
