using System;
using System.Collections.Generic;

using MyRestaurant.Models;
using MyRestaurant.Storage;

namespace MyRestaurant
{

    public class RestaurantOrderSystem
    {
        /*** CONSTRUCTOR ***/
        public RestaurantOrderSystem(IStoreFoodItems foodItemStorage) {
            // Init storage using Dependency Injection
            _foodItemStorage = foodItemStorage;

            // Create 3 sample food items
            _foodItemStorage.Create(new FoodItem(201, "Rice", "Plain Rice", "MainCourse","Veg",10,5));
            _foodItemStorage.Create(new FoodItem(202, "Curry", "Lentils", "MainCourse","Veg",20,5));
            _foodItemStorage.Create(new FoodItem(203, "Chicken", "Chicken","MainCourse","NonVeg",30,5));
            _foodItemStorage.Create(new FoodItem(201, "CheezeCake", "Soft cheez cake, no eggs", "Desert","Veg",7,10));
           
        }

        /*** STORAGE ***/
        private readonly IStoreFoodItems _foodItemStorage;
       
        

        /*** METHODS ***/
        public List<FoodItem> SearchForFoodItemByCourse(string p_courseToSearch) {
            return _foodItemStorage.GetByCourse(p_courseToSearch);
        }

        public List<FoodItem> SearchForFoodItemByType(string p_dietType) {
            return _foodItemStorage.GetByDietType(p_dietType);
        }

        public List<FoodItem> GetMenu() {
            return _foodItemStorage.GetAll();
        }

    }
}