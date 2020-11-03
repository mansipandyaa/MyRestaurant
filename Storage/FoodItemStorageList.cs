using System;
using System.Collections.Generic;
using System.Linq;

using MyRestaurant.Models;

namespace MyRestaurant.Storage
{
    public class FoodItemStorageList : IStoreFoodItems
    {
        private readonly List<FoodItem> _foodItemList;

        public FoodItemStorageList() {
            _foodItemList = new List<FoodItem>();
        }

        public void Create(FoodItem newFoodItem) {
            _foodItemList.Add(newFoodItem);
        }
        
        public FoodItem GetById(long id) {
            var t_FoodItem = _foodItemList.Find(x => x.Id == id);

            if (t_FoodItem == null) {
                throw new Exception($"Food Item {id} does not exist!!");
            }

            return t_FoodItem;
        }

        public List<FoodItem> GetByCourse(string p_course) {
            return _foodItemList.Where(x => x.Course.ToLower() == p_course.ToLower()).ToList();
        }

         public List<FoodItem> GetByDietType(string p_diet_type) {
            return _foodItemList.Where(x => x.DietType.ToLower() == p_diet_type.ToLower()).ToList();
        }

        public List<FoodItem> GetAll() {
            return _foodItemList;
        }
    }
}