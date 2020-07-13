using Quanlynhahang.DAO.Implements;
using Quanlynhahang.Models;
using Quanlynhahang.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quanlynhahang.Handle
{
     public class GetFoodByIdHandle
    {
        private ListFoods listFood;
        private Food food;

        public GetFoodByIdHandle(ListFoods listFood, Food food)
        {
            this.listFood = listFood;
            this.food = food;
        }
        public void Handle(object sender ,EventArgs e)
        {
            List<Food> list = new FoodDAO().GetFoodById(food.Id); 
        }
    }
}
