using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Quanlynhahang.DAO.Implements;
using Quanlynhahang.Models;
using Quanlynhahang.Handle;

namespace Quanlynhahang.Views
{
    public partial class ListTable : UserControl
    {
        public List<Desk> listDesk = new List<Desk>();
        public Bill CurrentBill = null;
        public List<BillDetail> ListBillDetail = null;
        public Account Account { get; set; }
        public ListTable(Account account)
        {
            InitializeComponent();
            Account = account;
        }
    
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void handle(object sender, EventArgs e)
        {
            
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnAddBillDetail_Click(object sender, EventArgs e)
        {
            string foodId =CbFood.SelectedValue.ToString();
            int quanlity = (int)NrQuantity.Value;
            new AddBillDetailHandle(this).Handle(foodId, quanlity);
        }

        private void CbTypeFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            string typeId = CbTypeFood.SelectedValue.ToString();
            CbFood.DataSource = new FoodDAO().GetFoodByFoodType(typeId);
            CbFood.ValueMember = "Id";
            CbFood.DisplayMember = "Name";
        }
        public void DisplayBillDetail(BillDetail billDetail)
        {
            TblBillDetail.Items.Insert(0, billDetail.FoodId);
            TblBillDetail.Items.Insert(0, billDetail.FoodId);
            TblBillDetail.Items.Insert(0, billDetail.Quantity + "");
            TblBillDetail.Items.Insert(0, 22 + "");
        }

        private void ListTable_Load(object sender, EventArgs e)
        {
            new LoadDeskHandle(this).Handle();
            
            //CbTypeFood
            CbTypeFood.DataSource = new FoodTypeDao().GetFoodType();
            CbTypeFood.ValueMember = "Id";
            CbTypeFood.DisplayMember = "Name";
            //CbFood
            string typeId = (string)CbTypeFood.SelectedValue;
            CbFood.DataSource = new FoodDAO().GetFoodByFoodType(typeId);
            CbFood.ValueMember = "Id";
            CbFood.DisplayMember = "Name";
        }
        public void LisTableRefresh()
        {
            new LoadDeskHandle(this).Handle();
        }
        //DisplayDesk
        public void DisplayDeskList ( List<Desk> list)
        {
            if(listDesk.Count == 0)
            {
                listDesk = list;
            }
            this.DeskList.Controls.Clear();
            foreach(var d in list)
            {
                Views.Table table = new Views.Table(d);
                table.DeleteDeskClick(new DeleteDeskHandle(this, d).Handle);
                table.TableClick(new GetBillByIdDeskHandle(this, d).Handle);
                table.ChangeStateClick(new ChangeStateClick(this, d).Handle);
                this.DeskList.Controls.Add(table);
            }
        }
        public void ChangeState(Desk d)
        {
            Table table = new Table(d);
            int index = this.DeskList.Controls.GetChildIndex(table);
            Table t = (Table)this.DeskList.Controls[index];
            t.BackColor = Color.Purple;
            t.State.Text = "Bàn bận";
            t.State.ForeColor = Color.Red;
        }
        //Show Bill
        public void ShowBill(string idDesk)
        {

        }
        
    }
}
