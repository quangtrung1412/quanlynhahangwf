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
        public List<Bill> ListBill = new List<Bill>();
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
           /* string foodId =CbFood.SelectedValue.ToString();
            int quanlity = (int)NrQuantity.Value;
            new AddBillDetailHandle(this).Handle(foodId, quanlity);*/
        }

        
        public void DisplayBillDetail(BillDetail billDetail)
        {
           /* TblBillDetail.Cells
            TblBillDetail.Items.Insert(0, billDetail.FoodId);
            TblBillDetail.Items.Insert(0, billDetail.Quantity + "");
            TblBillDetail.Items.Insert(0, 22 + "");*/
        }

        private void ListTable_Load(object sender, EventArgs e)
        {
            if(this.listDesk.Count == 0)
            {
                new LoadDeskHandle(this).Handle();
            }
            
            
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
                table.TableClick(new GetBillByIdDeskHandle(this, d).Handle);
                table.ChangeStateClick(new ChangeStateClick(this, d).Handle);
                this.DeskList.Controls.Add(table);
            }
        }
        public void DisplayBookForm(Bill bill)
        {
            BookDesk bookDesk = new BookDesk(this, bill);
            bookDesk.ShowDialog();
           
        }
        public void ChangeState(Desk d)
        {
            Table table = new Table(d);
            int index = this.DeskList.Controls.GetChildIndex(table);
            Table t = (Table)this.DeskList.Controls[index];
            t.BackColor = Color.Purple;
            t.State.Text = "Bàn bận";
            t.State.ForeColor = Color.Red;
            t.ChangeState.Enabled = false;
        }
        public void EmplyDesk (Desk d)
        {
            Table table = new Table(d);
            int index = this.DeskList.Controls.GetChildIndex(table);
            Table t = (Table)this.DeskList.Controls[index];
            t.BackColor = Color.Teal;
            t.State.Text = "Bàn trống";
            t.State.ForeColor = Color.White;
            t.ChangeState.Enabled = true;
            MessageBox.Show("Thanh toán thành công");
        }
        //Show Bill
        public void ShowBill(string idDesk)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
