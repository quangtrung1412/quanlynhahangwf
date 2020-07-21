using Quanlynhahang.DAO.Implements;
using Quanlynhahang.Handle;
using Quanlynhahang.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quanlynhahang.Views
{
    public partial class BookDesk : Form
    {
        public ListTable listTable { get; set; }
        public Bill bill { get; set; }

        public BookDesk()
        {
            InitializeComponent();
        }
        public BookDesk(ListTable lt, Bill b)
        {
            InitializeComponent();
            listTable = lt;
            bill = b;
        }
        private void BookDesk_Load(object sender, EventArgs e)
        {
            CbTypeFood.DataSource = new FoodTypeDao().GetFoodType();
            CbTypeFood.ValueMember = "Id";
            CbTypeFood.DisplayMember = "Name";
            //CbFood
            string typeId = (string)CbTypeFood.SelectedValue;
            CbFood.DataSource = new FoodDAO().GetFoodByFoodType(typeId);
            CbFood.ValueMember = "Id";
            CbFood.DisplayMember = "Name";
            if(bill.ListBillDetail.Count > 0)
            {
                foreach(var bd in bill.ListBillDetail)
                {
                    int price = bd.Food.Price * (int)bd.Quantity;
                    dgBillDetail.Rows.Add(bd.Food.Name, bd.Food.Price, bd.Quantity, price);
                    int totalPrice = int.Parse(TxtTotal.Text) + price;
                    TxtTotal.Text = totalPrice + "";
                }
            }
        }

        private void CbTypeFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            string typeId = CbTypeFood.SelectedValue.ToString();
            CbFood.DataSource = new FoodDAO().GetFoodByFoodType(typeId);
            CbFood.ValueMember = "Id";
            CbFood.DisplayMember = "Name";
        }

        private void BtnAddBillDetail_Click(object sender, EventArgs e)
        {
            Food food = (Food)CbFood.SelectedItem;
            int quanlity = (int)NrQuantity.Value;
            if(quanlity > 0)
            {
                new AddBillDetailHandle(this).Handle(food, quanlity);
            } else
            {
                MessageBox.Show("Vui lòng chọn số lượng");
            }
        }
        public void DisplayBillDetail(BillDetail bd)
        {
            int price = bd.Food.Price *(int)bd.Quantity;
            dgBillDetail.Rows.Add(bd.Food.Name, bd.Food.Price,bd.Quantity,price);
            int totalPrice = int.Parse(TxtTotal.Text) + price;
            TxtTotal.Text = totalPrice + "";
        }

        private void BtnPay_Click(object sender, EventArgs e)
        {
            if(bill.ListBillDetail.Count > 0)
            {
                bool result = new PaymentHandle(this).Handle(bill);
                if(result)
                {
                    foreach(var tb in this.listTable.listDesk)
                    {
                        if(bill.DeskId.Equals(tb.Id))
                        {
                            listTable.EmplyDesk(tb);
                            break;
                        }
                    }
                    this.listTable.ListBill.Remove(bill);
                    this.Dispose();
                }
            } else
            {
                MessageBox.Show("Vui lòng đặt món");
            }
        }
    }
}
