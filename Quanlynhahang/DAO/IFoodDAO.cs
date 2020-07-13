using Quanlynhahang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quanlynhahang.DAO
{
    public interface IFoodDAO
    {
        List<Food> GetAllFood();
        List<Food> GetFoodById(string id);
        bool InsertFood(Food f);
        bool UpdateFood(Food f);
        bool DeleteFood(string id);
        List<Food> SearchFoodByName(string name);
        List<Food> GetFoodByFoodType(string id);
    }
}
