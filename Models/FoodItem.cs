using System;

namespace MyRestaurant.Models
{
    public class FoodItem
    {
        public FoodItem(long p_id, string p_name, string p_description, string p_course, string p_diet_type,long p_price,int p_AvailableQty){

             Id=p_id;
             Name=p_name;
             Description=p_description;
             Course=p_course;
             DietType=p_diet_type;
             Price=p_price;
             AvailableQty=p_AvailableQty;              
             IsAvailable=true;

        }

        public long Id {get;}
        public string Name {get; private set;}
        public string Description {get; private set;}
        public string Course {get; private set;} //Starter, MainCourse, Desert
        public string DietType {get; private set;} //Veg, Non-veg 
        public long Price {get; private set;}
        public int AvailableQty {get; private set;} // No. of quantity 
        public bool IsAvailable {get; private set;}


        public void PackFoodItem(int requiredQty){

            if(IsAvailable)
            {
                if(requiredQty>AvailableQty)
                {
                        throw new Exception($"Food item {Name} has only {AvailableQty} quantity available");    
                }else{
                  
                   Console.WriteLine("Order Successfull");     

                   AvailableQty=AvailableQty-requiredQty;   

                   if(AvailableQty==0)
                   {
                       IsAvailable=false;
                   } 

                }

            }
            else
            {
                throw new Exception($"Food item {Name} is not available!");    
            }    


        }

        public override string ToString()
        {
            string details = $"\n----- Food Item {Id} -----\n";
            details += $"Name: {Name}\n";
            details += $"Description: {Description} \n";                       
            details += $"Course: {Course}\n";
            details += $"Diet Type: {DietType}\n";
            details += $"Price: {Price} CAD\n";
            details += $"Is Available: {IsAvailable}\n";
            details += $"Available Quantity: {AvailableQty}\n";
            details += "-------------------------\n";
            return details;
        }



    }
}
