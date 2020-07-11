using Quanlynhahang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quanlynhahang.DAO.Implements
{
    public class FoodTypeDao : IFoodTypeDao
    {
        private QuanLyNhaHangEntities db;
        public FoodTypeDao()
        {
            this.db = new QuanLyNhaHangEntities();

        }

        public List<FoodType> GetFoodType()
        {
            List<FoodType> list = new List<FoodType>();
            var resultSet = db.Usp_GetAllFoodType().ToList();
            if (resultSet.Count() > 0)
            {
                foreach(var u in resultSet)
                {
                    FoodType ft = new FoodType();
                    ft.Id = u.Id;
                    ft.Name = u.Name;
                    list.Add(ft);
                }
            }
            return list;
        }
    }
}
