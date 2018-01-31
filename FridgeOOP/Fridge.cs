using System;
using System.Collections.Generic;
using System.Text;

namespace FridgeOOP
{
    public class Fridge
    {
        //fields

        private bool isClean;
        private string dispenserType;
        private int foodAmount;
        private bool bulbsWork;

        //Properties

        public bool IsClean
        {
            get { return this.isClean; }
            set { this.isClean = value; }
        }

        public string DispenserType
        {
            get { return this.dispenserType; }
        }

        public int FoodAmount
        {
            get { return this.foodAmount; }
            set { this.foodAmount = value; }
        }

        public bool BulbsWork
        {
            get { return this.bulbsWork; }
            set { this.bulbsWork = value; }
        }

        //Constructors

        public Fridge()
        {
            this.dispenserType = "basic water dispenser"; //this default constructor sets the value for all instances, could have done also done
                                                          //this with: set {this.dispenserType = "basic water dispenser;}
        }

        public Fridge(string dispenserType)
        {

            this.dispenserType = dispenserType; //this assigns the value right to the field(?)
        }
            
         public Fridge(bool isClean, string dispenserType, int foodAmount, bool bulbsWork)
        {

            this.isClean = isClean;
            this.dispenserType = dispenserType;
            this.foodAmount = foodAmount;
            this.bulbsWork = bulbsWork;
        }  
            
        

        //Methods()

        //need methods to dispense water
        //change bulbs
        //clean fridge
        //check food supplies

        public void DispenseWater() //method for dispensing water, could have used a switch instead of if else
        {
            if (dispenserType == "basic water dispenser")
            {
                Console.WriteLine("Here's some lukewarm water!:");
            }
            else if (dispenserType == "deluxe dispenser")
            {
                Console.WriteLine("Enjoy your perfect ice water.");
                
            }
            else
            {
                Console.WriteLine("What's going to come out? It's a suprise!");
            }
        }



    }
}
