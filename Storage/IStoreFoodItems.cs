using System;
using System.Collections.Generic;
using MyRestaurant.Models;

namespace MyRestaurant.Storage
{
    public interface IStoreFoodItems
    {
        void Create(FoodItem newFoodItem);
        
        FoodItem GetById(long p_id);

        List<FoodItem> GetByCourse(string p_course);
        List<FoodItem> GetByDietType(string p_diet_type);

        List<FoodItem> GetAll();
    }
}