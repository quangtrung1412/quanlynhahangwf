using Quanlynhahang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quanlynhahang.DAO.Implements
{
    class BillDAO : IBillDAO
    {
        private QuanLyNhaHangEntities db;

        public BillDAO()
        {
            this.db = new QuanLyNhaHangEntities();
        }
        public List<Bill> GetAllBill(DateTime from, DateTime to)
        {
            List<Bill> list = new List<Bill>();
            var resultSet = db.Usp_GetAllBill(from, to);
            if (resultSet.Count() > 0)
            {
                foreach(var u in resultSet)
                {
                    Bill b = new Bill();
                    b.Id = u.Id;
                    b.DeskId = u.DeskId;
                    b.AccountId = b.AccountId;
                    b.Total = u.Total;
                    b.CreatedAt = u.CreatedAt;
                    list.Add(b);
                }
            }
            return list;
        }

        public List<BillDetail> GetAllBillDetail()
        {
            List<BillDetail> listB = new List<BillDetail>();
            var resultSet = db.Usp_GetAllBillDetail();
            if (resultSet.Count() > 0)
            {
                foreach(var u in resultSet)
                {
                    BillDetail bd = new BillDetail();
                    bd.Id = u.Id;
                    bd.BillId = u.BillId;
                    bd.FoodId = u.FoodId;
                    bd.Quantity = u.Quantity;
                }
            }
            return listB;
        }
    }
}
