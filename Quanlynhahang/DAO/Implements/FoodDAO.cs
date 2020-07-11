using Quanlynhahang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quanlynhahang.DAO.Implements
{
    public class FoodDAO : IFoodDAO
    {
        private QuanLyNhaHangEntities db;

        public FoodDAO()
        {
            this.db = new QuanLyNhaHangEntities();
        }

        public bool DeleteFood(string id)
        {
            throw new NotImplementedException();
        }

        public List<Food> GetAllFood()
        {
            List<Food> listF = new List<Food>();
            var resultSet = db.Usp_GetAllFood().ToList();
            if (resultSet.Count() > 0)
            {
                foreach(var u in resultSet)
                {
                    Food f = new Food();
                    f.Id = u.Id;
                    f.TypeId = u.TypeId;
                    f.Name = u.Name;
                    f.Price = u.Price;
                    f.Unit = u.Unit;
                    f.Picture = u.Picture;
                    f.Status = u.Status;
                    listF.Add(f);
                }
            }
            return listF;
        }

        public List<Food> GetFoodById(string id)
        {
            throw new NotImplementedException();
        }

        public bool InsertFood(Food f)
        {
            throw new NotImplementedException();
        }

        public List<Food> SearchFoodByName(string name)
        {
            throw new NotImplementedException();
        }

        public bool UpdateFood(Food f)
        {
            throw new NotImplementedException();
        }
    }
}
