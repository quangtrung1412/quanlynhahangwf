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
        public ListTable()
        {
            InitializeComponent();
            
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

        }

        private void CbTypeFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            string typeId = CbTypeFood.SelectedValue.ToString();
            CbFood.DataSource = new FoodDAO().GetFoodByFoodType(typeId);
            CbFood.ValueMember = "Id";
            CbFood.DisplayMember = "Name";
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
                Views.Table table = new Views.Table(d.Id, d.Name,(byte)d.Status);
                table.ChangeStateClick(new ChangeStateClick(this, d).Handle);
                this.DeskList.Controls.Add(table);
            }
        }
        public void ChangeState(Desk d)
        {

        }
        
    }
}
