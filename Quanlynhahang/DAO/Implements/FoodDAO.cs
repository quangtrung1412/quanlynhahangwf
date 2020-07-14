using Quanlynhahang.Models;
using Quanlynhahang.Views;
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

        public bool  DeleteFood(string id)
        {
            
            int i = db.Usp_DeleteFood(id);
            if (i == 1)
            {
                return  true;
            }
            else
            {
                return false;
            }
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

        public List<Food> GetFoodByFoodType(string id)
        {
            List<Food> listF = new List<Food>();
            
            var resultSet = db.Usp_GetFoodByFoodType(id).ToList();
            if (resultSet.Count() > 0)
            {
                foreach (var u in resultSet)
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
            List<Food> listF = new List<Food>();

            var resultSet = db.Usp_GetFoodById(id).ToList();
            if (resultSet.Count() > 0)
            {
                foreach (var u in resultSet)
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

        public bool InsertFood(Food f)
        {
            int i = db.Usp_InsertFood(f.Id,f.TypeId,f.Name,f.Price,f.Unit,f.Picture);
            if (i == 1)
            {
                return true;
            }
            return false;
        }

        public List<Food> SearchFoodByName(string name)
        {
            List<Food> listF = new List<Food>();

            var resultSet = db.Usp_SearchFoodByName(name).ToList();
            if (resultSet.Count() > 0)
            {
                foreach (var u in resultSet)
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

        public bool UpdateFood(Food f)
        {
            int i = db.Usp_UpdateFood(f.Id, f.TypeId, f.Name, f.Price, f.Unit, f.Picture);
            if (i == 1)
            {
                return true;
            }
            return false;
        }
    }
}
