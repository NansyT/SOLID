using System;

namespace CoffeeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = "";
            float amount = 0;
            CoffeeMachine machine = new CoffeeMachine();
            while (choice != "x")
            {
                Console.Clear();
                Console.WriteLine("Hello, choose an option: \n" +
                    "Press 'w' to fill water on the coffee machine \n" +
                    "Press 'c' to fill coffee beans on the coffee machine \n" +
                    "Press 's' to turn machine on or off. \n" +
                    "Press 'h' to heat you water \n" +
                    "Press 'b' to brew a coffee. \n" +
                    "Press 'x' to exit.");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "w":
                        Console.WriteLine("Please enter the amount of water you want to pour into the machine");
                        amount = float.Parse(Console.ReadLine());
                        Console.WriteLine(machine.FillWater(amount));
                        break;
                    case "c":
                        Console.WriteLine("Please enter the amount of coffee beans you want to pour into the machine");
                        amount = float.Parse(Console.ReadLine());
                        Console.WriteLine(machine.FillCoffeeBeans(amount));
                        break;
                    case "s":
                        Console.WriteLine(machine.ChangeState());
                            break;
                    case "b":
                        Console.WriteLine(machine.BrewCoffee());
                        break;
                    case "h":
                        Console.WriteLine(machine.HeatWater());
                        break;
                    case "x":
                        Console.WriteLine("Turning off...");
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Press enter to continue...");
                Console.ReadLine();
            }
        }
    }
}
