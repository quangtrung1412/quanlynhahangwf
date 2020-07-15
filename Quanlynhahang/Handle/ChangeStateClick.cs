using Quanlynhahang.DAO.Implements;
using Quanlynhahang.Models;
using Quanlynhahang.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quanlynhahang.Handle
{
    public class ChangeStateClick
    {
        private ListTable listTable;
        private Desk d;

        public ChangeStateClick(ListTable listTable,Desk d)
        {
            this.listTable = listTable;
            this.d = d; 
        }
        public void Handle(object sender,EventArgs e)
        {
            listTable.ChangeState(d);
            listTable.CurrentBill = new Bill();
            listTable.CurrentBill.Id = "bill" + DateTime.Now.ToUniversalTime().Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;
            listTable.CurrentBill.DeskId = d.Id;
            listTable.CurrentBill.Status = 0;
            listTable.CurrentBill.AccountId = listTable.Account.Id;
            listTable.ListBillDetail = new List<BillDetail>();
            new BillDAO().InsertBill(listTable.CurrentBill);
        }
    }
}
