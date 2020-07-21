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
    public class PaymentHandle
    {
        private BookDesk bookDesk;

        public PaymentHandle(BookDesk bookDesk)
        {
            this.bookDesk = bookDesk;
        }
        public bool Handle(Bill bill)
        {
            bool kq = true;
            bool result = new BillDAO().InsertBill(bill);
            if(result)
            {
                foreach(var bdt in bill.ListBillDetail)
                {
                    bool rs = new BillDetailDao().InsertBillDetail(bdt);
                    if(rs)
                    {
                        continue;
                    } else
                    {
                        kq = false;
                        MessageBox.Show("Lỗi");
                        break;
                    }
                }
            }else
            {
                kq = false;
            }
            return kq;
        }
    }
}
