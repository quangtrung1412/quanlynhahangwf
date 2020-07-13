using Quanlynhahang.DAO.Implements;
using Quanlynhahang.Models;
using Quanlynhahang.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quanlynhahang.Handle
{
     public class EditFoodHandle
    {
        private ListFoods listFood;

        public EditFoodHandle(ListFoods listFood)
        {
            this.listFood = listFood;
        }
        public void Handle(object sender, EventArgs e)
        {
            Food f = listFood.FormFood.GetFood();
            if (f != null)
            {
                bool b = new FoodDAO().UpdateFood(f);
                if (b)
                {
                    listFood.DisplayNewFood(f);
                    listFood.CloseFormFood();
                }
                else
                {
                    listFood.DisplayErrorAddFood();
                }
            }
        }

    }
}
