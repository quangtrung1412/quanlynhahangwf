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
    public class DeleteFoodHandle
    {
        private ListFoods listFood;
        private Food food;

        public DeleteFoodHandle(ListFoods listFood, Food food)
        {
            this.listFood = listFood;
            this.food = food;

        }
        public void Handle(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xóa món ăn :" + food.Name, "Xóa", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                bool bl = new FoodDAO().DeleteFood(food.Id);
                listFood.ListFoods_Refresh();
            }
        }
    }
}
