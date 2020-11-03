using System;
using System.Collections.Generic;
using MyRestaurant.Models;
using MyRestaurant.Storage;


namespace MyRestaurant
{
    class Program
    {
        static void Main(string[] args)
        {
             var foodItemStorage = new FoodItemStorageList();
             var theOrderingSystem = new RestaurantOrderSystem(foodItemStorage);            

             Console.WriteLine("Welcome to the Mandar's Kitchen!");

            while (true) {
                Console.WriteLine("\nPlease select an option:\n" +
                    "- m: print menu\n" +                                        
                    "- c: search for items by course\n" +
                    "- d: search for items by diet type\n" +                    
                    "- q: quit\n"
                );
                string userInput = Console.ReadLine();                

            // Print Menu
                if (userInput == "m") {
                    try {
                        List<FoodItem> results = theOrderingSystem.GetMenu();
                        foreach (var t_foodItem in results) {
                            Console.WriteLine(t_foodItem.ToString());
                        } 
                    } catch (Exception e) {
                        Console.WriteLine($"Error: {e.Message}");
                    }
                }


                    // Search for a items by course Starter/MainCourse/Desert
                if (userInput == "c") {
                    try {
                        Console.WriteLine("What you want to order now: Starter, MainCourse or Desert?");
                        string p_courseToSearch = Console.ReadLine();
                        List<FoodItem> results = theOrderingSystem.SearchForFoodItemByCourse(p_courseToSearch);
                        
                        if (results.Count == 0) {
                            Console.WriteLine("No matching items were found");
                        } else {
                            foreach (var t_foodItem in results) {
                                Console.WriteLine(t_foodItem.ToString());
                            } 
                        }
                    } catch (Exception e) {
                        Console.WriteLine($"Error: {e.Message}");
                    }
                    
                }

                 if (userInput == "d") {
                    try {
                        Console.WriteLine("What types of diet: Veg or NonVeg?");
                        string p_dietType = Console.ReadLine();
                        List<FoodItem> results = theOrderingSystem.SearchForFoodItemByType(p_dietType);
                        
                        if (results.Count == 0) {
                            Console.WriteLine("No matching items were found");
                        } else {
                            foreach (var t_foodItem in results) {
                                Console.WriteLine(t_foodItem.ToString());
                            } 
                        }
                    } catch (Exception e) {
                        Console.WriteLine($"Error: {e.Message}");
                    }
                    
                }





                 // Quit
                if (userInput == "q") {
                    break;
                }

            }
           



        }
    }
}
