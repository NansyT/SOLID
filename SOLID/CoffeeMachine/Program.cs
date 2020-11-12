using System;

namespace CoffeeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = "";
            float amount = 0;
            CombiMachine machine = new CombiMachine();
            while (choice != "x")
            {
                Console.Clear();
                Console.WriteLine("Hello, choose an option: \n" +
                    "Press 'w' to fill water on the machine \n" +
                    "Press 'c' to fill coffee beans on the machine \n" +
                    "Press 't' to fill tea leaves on the machine \n" +
                    "Press 's' to turn machine on or off. \n" +
                    "Press 'h' to heat you water \n" +
                    "Press 'b' to brew coffee. \n" +
                    "Press 'n' to brew tea \n" +
                    "Press 'e' to brew espresso (you only get one cup tho)\n" +
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
                    case "t":
                        Console.WriteLine("Please enter the amount of tea leaves you want to pour into the machine");
                        amount = float.Parse(Console.ReadLine());
                        Console.WriteLine(machine.FillTea(amount));
                        break;
                    case "s":
                        Console.WriteLine(machine.ChangeState());
                        break;
                    case "h":
                        Console.WriteLine(machine.HeatWater());
                        break;
                    case "b":
                        Console.WriteLine(machine.BrewCoffee());
                        break;
                    case "n":
                        Console.WriteLine(machine.BrewTea());
                        break;
                    case "e":
                        Console.WriteLine(machine.BrewEspresso());
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
