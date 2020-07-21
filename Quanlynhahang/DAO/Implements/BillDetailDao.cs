using Quanlynhahang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quanlynhahang.DAO.Implements
{
    public class BillDetailDao : IBillDetailDao
    {
        private QuanLyNhaHangEntities db;

        public BillDetailDao()
        {
            this.db = new QuanLyNhaHangEntities();
        }
        public bool InsertBillDetail(BillDetail bd)
        {
            int result = db.Usp_InsertBillDetail(bd.FoodId, bd.BillId, bd.Quantity);
            if(result == 1)
            {
                return true;
            }
            return false;
        }
    }
}
