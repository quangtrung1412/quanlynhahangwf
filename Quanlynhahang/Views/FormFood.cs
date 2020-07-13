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
    public partial class FormFood : Form
    {
        private Food food;
        
        public FormFood()
        {
            InitializeComponent();
        }
        public FormFood(Food food)
        {
            InitializeComponent();
            this.food = food;
            this.txtFoodId.Text = food.Id;
            this.cbFoodType.ValueMember = food.TypeId;
            this.txtFoodName.Text = food.Name;
            this.numPrice.Value = food.Price;
            this.txtUnit.Text = food.Unit;

        }
        private void FormFood_Load(object sender, EventArgs e)
        {

            cbFoodType.DataSource = new FoodTypeDao().GetFoodType();
            cbFoodType.ValueMember = "Id";
            cbFoodType.DisplayMember = "Name";
        }
        public void BtnAddFoodClick(EventHandler e)
        {
            this.btnAddFood.Click += e;
        }
        public Food GetFood()
        {
            int i = 0;
            Food f = new Food();
            f.Id = "food" + DateTime.Now.ToUniversalTime().Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;
            f.Name = txtFoodName.Text.Trim();
            f.Price = (int)numPrice.Value;
            f.TypeId = cbFoodType.SelectedValue.ToString();
            f.Unit = txtUnit.Text.Trim();
            f.Picture = "foodpicture.png";
            if (f.Name.Length == 0 || f.Unit.Length == 0)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                i = 1;
            }
            if (i == 0)
            {
                return f;
            }
            return null;
        }
    }
}
