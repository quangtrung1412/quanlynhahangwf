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
    public class InsertFoodHandle
    {
        private ListFoods listFood;

        public InsertFoodHandle(ListFoods listFoods)
        {
            this.listFood = listFoods;
        }
        public void Handle(object sender, EventArgs e)
        {
            Food f = listFood.FormFood.GetFood();
            if(f!= null)
            {
               bool b =  new FoodDAO().InsertFood(f);
                if(b)
                {
                    listFood.DisplayNewFood(f);
                    listFood.CloseFormFood();
                } else
                {
                    listFood.DisplayErrorAddFood();
                }
            }
        }
    }
}
