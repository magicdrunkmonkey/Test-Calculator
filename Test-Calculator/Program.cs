using System;

namespace Test_Calculator
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Declaring and initilize variables
            bool menuLoop = true;
            int menuOption, menuOption1=-1;
            double num1 = 0, num2 = 0, result;


            //Menu
            while (menuLoop)
            {
                Console.Clear();
                Console.WriteLine("Calculator");
                Console.WriteLine("-------------");
                // Ask the user to choose an option.
                Console.WriteLine("Choose an option from the following list:\n\n");
                Console.WriteLine(
                    "1) Add\n"+
                    "2) Subtract\n"+
                    "3) Multiply\n"+
                    "4) Divide\n");
                
                Console.WriteLine("0) Quit Calculator\n");

                //Menu input
                Console.Write("\nChoose option and press [Enter]: ");
                try
                {
                    menuOption1 = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Not a valid input!");
                }

                menuOption = menuOption1;
                switch (menuOption)
                {
                    case 1: //Add
                        {
                            UserInput();
                            result = Operator.Add(num1, num2);
                            Console.WriteLine("{0} + {1} = {2}", num1, num2, result);

                            PressAnyKeyToMenu();
                            break;
                        }

                    case 2: //Subract
                        {
                            UserInput();
                            result = Operator.Subtract(num1, num2);
                            Console.WriteLine("{0} - {1} = {2}", num1, num2, result);

                            PressAnyKeyToMenu();
                            break;
                        }

                    case 3: //Multiply
                        {
                            UserInput();

                            result = Operator.Multiply(num1, num2);
                            Console.WriteLine("{0} * {1} = {2}", num1, num2, result);

                            PressAnyKeyToMenu();
                            break;
                        }

                    case 4: //Divide
                        {
                            UserInput();

                            result = Operator.Divide(num1, num2);
                            if (num2 != 0)
                            {
                                Console.WriteLine("{0} / {1} = {2}", num1, num2, result);
                            }                            

                            /*
                            if (result == 0)
                            {
                                Console.WriteLine("\nThe denominator can not be zero");
                            }
                            else
                            {
                                Console.WriteLine("{0} / {1} = {2}", num1, num2, result);
                            }
                            */

                            PressAnyKeyToMenu();                            
                            break;
                        }

                    case 0: //Quit Calculator
                        {
                            menuLoop = false;
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("\nThe option is not in the selection.");

                            PressAnyKeyToMenu();
                            break;
                        }
                }
            }

            void UserInput()
            {
                bool keepLooping = true;
                while (keepLooping)
                {
                    try
                    {
                        // Ask the user to type the first number.
                        Console.Write("\nType the first number, and then press Enter: ");
                        num1 = Convert.ToDouble(Console.ReadLine());

                        // Ask the user to type the second number.
                        Console.Write("Type the second number, and then press Enter: ");
                        num2 = Convert.ToDouble(Console.ReadLine());

                        keepLooping = false;
                    }
                    catch
                    {
                        Console.WriteLine("Not a valid number!");
                    }                    
                }
            }

            void PressAnyKeyToMenu()
            {
                Console.WriteLine("\nPress any key to return to menu...");
                Console.ReadKey();                
            }
            
        }
    }
}