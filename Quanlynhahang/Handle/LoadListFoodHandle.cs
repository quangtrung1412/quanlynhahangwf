using Quanlynhahang.DAO.Implements;
using Quanlynhahang.Models;
using Quanlynhahang.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quanlynhahang.Handle
{
    public class LoadListFoodHandle
    {
        public LoadListFoodHandle(ListFoods lf)
        {
            this.ListFood = lf;
        }

        public ListFoods ListFood { get; }
        public void Handle()
        {
            List<Food> list = new FoodDAO().GetAllFood();
            ListFood.DisplayFoodList(list);
        }
    }
}
