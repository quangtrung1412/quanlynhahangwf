using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Quanlynhahang.DAO.Implements;

namespace Quanlynhahang.Views
{
    public partial class ListTable : UserControl
    {
        public ListTable()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                Views.Table tb = new Views.Table();
                this.flowLayoutPanel1.Controls.Add(tb);
                tb.TableClick(handle);

            }
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
    }
}
