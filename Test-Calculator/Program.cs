using System;

namespace Calculator
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Declaring and initilize variables
            bool menuLoop = true;
            int menuOption;
            double num1, num2, result;


            //Menu
            while (menuLoop)
            {
                Console.Clear();
                Console.WriteLine("Calculator");
                Console.WriteLine("-------------");
                // Ask the user to choose an option.
                Console.WriteLine("Choose an option from the following list:\n");
                Console.WriteLine("\n1) Add");
                Console.WriteLine("2) Subtract");
                Console.WriteLine("3) Multiply");
                Console.WriteLine("4) Divide");
                Console.WriteLine("\n\n0) Quit Calculator");

                //Menu input
                Console.Write("\nChoose option and press [Enter]: ");
                menuOption = Convert.ToInt32(Console.ReadLine());

                switch (menuOption)
                {
                    case 1: //Add
                        {
                            UserInput();
                            result = Operator.Add(num1, num2);
                            Console.WriteLine("{0} + {1} = {2}", num1, num2, result);

                            Console.WriteLine("\nPress any key to return to menu...");
                            Console.ReadKey();
                            break;
                        }

                    case 2: //Subract
                        {
                            UserInput();
                            result = Operator.Subtract(num1, num2);
                            Console.WriteLine("{0} - {1} = {2}", num1, num2, result);

                            Console.WriteLine("\nPress any key to return to menu...");
                            Console.ReadKey();
                            break;
                        }

                    case 3: //Multiply
                        {
                            UserInput();
                            result = Operator.Multiply(num1, num2);
                            Console.WriteLine("{0} * {1} = {2}", num1, num2, result);

                            Console.WriteLine("\nPress any key to return to menu...");
                            Console.ReadKey();
                            break;
                        }

                    case 4: //Divide
                        {
                            UserInput();
                            result = Operator.Divide(num1, num2);

                            if (num2 == 0)
                            {
                                Console.WriteLine("\nThe denominator can not be zero");
                            }
                            else
                            {
                                Console.WriteLine("{0} / {1} = {2}", num1, num2, result);
                            }

                            Console.WriteLine("\nPress any key to return to menu...");
                            Console.ReadKey();
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

                            Console.WriteLine("\nPress any key to return to the menu ...");
                            Console.ReadKey();
                            break;
                        }
                }
            }

            void UserInput()
            {
                // Ask the user to type the first number.
                Console.WriteLine("Type the first number, and then press Enter");
                num1 = Convert.ToDouble(Console.ReadLine());

                // Ask the user to type the second number.
                Console.WriteLine("Type the second number, and then press Enter");
                num2 = Convert.ToDouble(Console.ReadLine());
            }

        }
    }
}