using Quanlynhahang.DAO.Implements;
using Quanlynhahang.Models;
using Quanlynhahang.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quanlynhahang.Handle
{
    public class SearchFoodByNameHandel
    {
        private ListFoods listFoods { get; }

        public SearchFoodByNameHandel(ListFoods listFoods)
        {
            this.listFoods = listFoods;
        }
        public void Handel(Object sender,EventArgs e)
        {
            string name=listFoods.GetNameSearch();

            if (name.Length == 0)
            {
                List<Food> l = new FoodDAO().GetAllFood();
                listFoods.DisplayFoodList(l);
            }
            else
            {

                List<Food> list = new FoodDAO().SearchFoodByName(name);
                listFoods.DisplayFoodList(list);
            }

        }
    }
}
