using System;

namespace FridgeOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an interactive console window
            //prompt user to choose what to do with the fridge
            //call methods on fridge object to do what the user wants

            int userChoice;
            Fridge userFridge = new Fridge(false, "deluxe dispense", 70, true);
            do
            {
                Console.WriteLine("Hello, welcome to the fridge app.");
                Console.WriteLine("What would you like to do with your fridge?");
                Console.WriteLine("To dispense water, type 1");
                Console.WriteLine("To change lightbulb, type 2");
                Console.WriteLine("To clean your fridge, type 3");
                Console.WriteLine("To take food from your fridge, type 4");
                Console.WriteLine("To check food supplies, type 5");
                Console.WriteLine("To see all fridge details, type 6");
            //  Console.WriteLine("To restart, type 7");
                Console.WriteLine("To quit, type 8");

                userChoice = int.Parse(Console.ReadLine());

                

                switch (userChoice)
                {
                    case 1:
                        userFridge.DispenseWater(); //void, console.writeline in method
                        break;

                    case 2:
                        Console.WriteLine(userFridge.ChangeBulbs()); //returned a string, had to write value to console
                        break;

                    case 3:
                        Console.WriteLine(userFridge.Clean());
                        break;

                    case 4:
                        Console.WriteLine("How much food would you like to remove? Please enter a number of items");
                        int usersFood = int.Parse(Console.ReadLine());
                        userFridge.RemoveFood(usersFood);
                        break;

                    case 5:
                        Console.WriteLine(userFridge.CheckSupplies());
                        break;

                    case 6:
                        Console.WriteLine("Your fridge has a  " + userFridge.DispenserType);
                        Console.WriteLine("Your fridge has a {0}.", userFridge.DispenserType);//another way to display the value
                        Console.WriteLine("Your bulbs " + userFridge.ChangeBulbs());
                        Console.WriteLine("Your fridge is "+ userFridge.Clean());
                        Console.WriteLine("You have " + userFridge.FoodAmount + "food.");
                        break;
                }

                } while (userChoice != 8);
            {

            }

        }
    }
}
