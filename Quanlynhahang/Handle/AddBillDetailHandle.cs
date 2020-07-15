using Quanlynhahang.Models;
using Quanlynhahang.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quanlynhahang.Handle
{
    public class AddBillDetailHandle
    {
        private ListTable listTable;

        public AddBillDetailHandle(ListTable listTable)
        {

            this.listTable = listTable;
        }
        public void Handle(string foodId, int quanlity)
        {
            BillDetail billDetail = new BillDetail();
            billDetail.FoodId = foodId;
            billDetail.Quantity = quanlity;
            billDetail.BillId = listTable.CurrentBill.Id;
            listTable.ListBillDetail.Add(billDetail);
            listTable.DisplayBillDetail(billDetail);
        }
    }
}
