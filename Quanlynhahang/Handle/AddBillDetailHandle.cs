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
        private BookDesk bookDesk;

        public AddBillDetailHandle(BookDesk bookDesk)
        {

            this.bookDesk = bookDesk;
        }
        public void Handle(Food food, int quanlity)
        {
            BillDetail billDetail = new BillDetail();
            billDetail.FoodId = food.Id;
            billDetail.Quantity = quanlity;
            billDetail.BillId = this.bookDesk.bill.Id;
            billDetail.Food = food;
            foreach (var bill in this.bookDesk.listTable.ListBill)
            {
                if (bill.Id.Equals(this.bookDesk.bill.Id))
                {
                    bill.ListBillDetail.Add(billDetail);
                }
            }
            this.bookDesk.DisplayBillDetail(billDetail);
        }
    }
}
