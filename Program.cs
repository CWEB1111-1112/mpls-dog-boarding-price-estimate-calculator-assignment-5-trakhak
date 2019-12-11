using System;
//Khali Tran Assignment 5
namespace assignment_five
{
    class Program
    {
        static void Main(string[] args)
        {
          //Create a three object instances of Estimate and output data using toString Method from Estimate class 
          //initializing variables

           //DECLARATIONS
            string DogName, DogOwner, code;
            int DogWeight, DayStayed;
            double cost = 0;
            double DAILY_RATE = 75.00, A_RATE = 169.00, C_RATE = 112.00;
            

            if((code == "A") || (code == "C")){
              cost = calcRate(DayStayed, code);
            }else if(code == "N"){
              cost = calcRate(DayStayed);
            }else{
              Console.WriteLine("Something went wrong try again");
            }
           //Create an array
           
           Estimate [] boarding = new Estimate[4];

           for(int x = 0; x < boarding.Length; x++){
               //Create object instance
               boarding[x] = new Estimate();

               Console.WriteLine("Please enter your name:");
               DogOwner = Console.ReadLine();

               Console.WriteLine($"Please enter dog name for {DogOwner}:");
               DogName = Console.ReadLine();

               Console.WriteLine($"Please enter {DogName}'s weight:");
               DogWeight = Convert.ToInt32(Console.ReadLine());

               Console.WriteLine($"Please enter number of days the dog will stay:");
               DayStayed = Convert.ToInt32(Console.ReadLine());

               Console.WriteLine($"Please enter code addition services code:");
               code = Console.ReadLine();


               //Set values for object instance
               boarding[x].DogOwner = DogOwner;
               boarding[x].DogName = DogName;

               boarding[x].DogWeight = DogWeight;
               boarding[x].DayStayed = DayStayed;

               boarding[x].code = code;

               //Ouput object data
               Console.WriteLine(boarding[x].ToString());
        }

        //Create a class called Estimate
    }

    class Estimate{
      
        public string DogOwner{get; set;}
        public string DogName {get; set;}
        public int DogWeight {get; set;}
        public int DayStayed {get; set;}
        public string code {get; set;}
        double DAILY_RATE = 75.00;
        double PRICE_A = 169.00;
        double PRICE_C = 112.00;
        public double cost {get;}

        public Estimate(){

        }

         void calcRate(){
          
          double cost;

          cost = DayStayed * DAILY_RATE;
          
        }

        public Estimate(string dogOwner, string dogName, int dogWeight, int dayStayed, string code){
          DogOwner = dogOwner;
          DogName = dogName;
          DogWeight = dogWeight;
          DayStayed = dayStayed;
          this.code = code;
          determinePrice();

        }

        private void determinePrice(){
          code = code.ToUpper();

          if((code == "A")){
            cost = PRICE_A
          }else if(code == "C"){
            cost = PRICE_C
          }else if(code == "N"){
            cost = DAILY_RATE
          }else{
            Console.WriteLine("Something went wrong try again");
          }

          cos
          return cost;
        }

        }

        public override String ToString(){
            return String.Format($"Dog Owner's Name:{DogOwner}\nDog: {DogName}\nWeight: {DogWeight}\nDayStayed: {DayStayed}\n code: {code}\ncost: {cost}");
        }
    }
    }
}
