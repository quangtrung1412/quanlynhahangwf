using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Quanlynhahang.Models;
using Quanlynhahang.DAO.Implements;
using Quanlynhahang.Handle;

namespace Quanlynhahang.Views
{
    public partial class ListFoods : UserControl
    {
        private Form1 form;
        public FormFood FormFood { get; set; } = null;
        
        public ListFoods()
        {
            InitializeComponent();

        }
        public ListFoods(Form1 form)
        {
            InitializeComponent();

            this.form = form;
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void DisplayFoodList(List<Food> list)
        {
            this.fpFoodList.Controls.Clear();
            foreach (var f in list)
            {
                Views.Foods food = new Views.Foods(f.Id, f.Name, f.Unit, f.Price, f.Picture);

                food.BtnDeleteFoodClick(new DeleteFoodHandle(this, f).Handle);
                this.fpFoodList.Controls.Add(food);
                this.Refresh();
            }
        }
        private void ListFoods_Load(object sender, EventArgs e)
        {
            new LoadListFoodHandle(this).Handle();
        }
        public void ListFoods_Refresh()
        {
            new LoadListFoodHandle(this).Handle();
        }
        //AddFood
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            Overlay overlay = new Overlay();
            overlay.Location = new Point(form.Location.X + 150, form.Location.Y + 26);
            overlay.Show();
            FormFood = new FormFood();
            FormFood.BtnAddFoodClick(new InsertFoodHandle(this).Handle);
            FormFood.ShowDialog();
            overlay.Dispose();
            FormFood = null;
        }
        public void DisplayNewFood(Food f)
        {
            Views.Foods food = new Views.Foods(f.Id, f.Name, f.Unit, f.Price, f.Picture);
            food.BtnDeleteFoodClick(new DeleteFoodHandle(this, f).Handle);
            this.fpFoodList.Controls.Add(food);
            this.Refresh();
        }
        public void DisplayErrorAddFood()
        {
            MessageBox.Show("Thêm không thành công");
        }
        public void CloseFormFood()
        {
            FormFood.Dispose();
            FormFood = null;
        }
        //EditFood
        public void BtnEditFood_Click(object sender, EventArgs e)
        {
            Overlay overlay = new Overlay();
            overlay.Location = new Point(form.Location.X + 150, form.Location.Y + 26);
            overlay.Show();
                  
        }
    }
}
