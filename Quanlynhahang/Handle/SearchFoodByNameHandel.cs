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
    public class SearchFoodByNameHandel
    {
        private ListFoods listFoods { get; }

        public SearchFoodByNameHandel(ListFoods listFoods)
        {
            this.listFoods = listFoods;
        }
        public void Handle(string name)
        {
            if(name.Length > 0)
            {
                List<Food> list = new FoodDAO().SearchFoodByName(name);
                listFoods.DisplayFoodList(list);
            } else
            {
                listFoods.DisplayFoodList(listFoods.ListFood);
            }
        } 
    }
}
