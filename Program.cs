using System;

namespace SENG8040_Assignment1
{
    class Program
    {
        public static int UserMenuSelection()
        {
            string userInput = "0";
            bool ValidUserInput = false;
           // int UserInputValidation;

            while (ValidUserInput == false)
            {
                Console.WriteLine("1.Get Rectangle Length \n2.Change Rectangle Length \n3.Get Rectangle Width \n4.Change Rectangle Width \n5.Get Rectangle Perimeter \n6.Get Rectangle Area \n7.Exit");
                userInput = Console.ReadLine();
                
                if (userInput != "1" && userInput != "2" && userInput != "3" && userInput != "4" && userInput != "5" && userInput != "6" && userInput != "7")
                {
                    Console.WriteLine("Please enter valid input from the given options!");
                }
                else
                {
                    Console.WriteLine("Entered option is: {0} \n", userInput);
                    ValidUserInput = true;
                }
            }

            return int.Parse(userInput);
        }

        public static int InputValidation(string UserEnteredValue)
        {
            int ValidInt=0;
            bool InputValueValidation = int.TryParse(UserEnteredValue,out ValidInt);
            if (InputValueValidation == true)
                return ValidInt;
            else
                return ValidInt;
        }
        static void Main(string[] args)
        {
            int ChoosenMenu = UserMenuSelection();
            int RectangleLength;
            int RectangleWidth;
            Rectangle rectangle = new Rectangle();
            Console.WriteLine(ChoosenMenu);
            try
            {
                while (ChoosenMenu != 7)
                {
                    switch (ChoosenMenu)
                    {
                        case 1:
                            RectangleLength = rectangle.GetLength();
                            Console.WriteLine("The Rectangle length is: {0}", RectangleLength);
                            ChoosenMenu = UserMenuSelection();
                            break;

                        case 2:
                            Console.WriteLine("Please enter rectangle length: ");
                            string length = Console.ReadLine();
                            if (InputValidation(length) == 0)
                            {
                                Console.WriteLine("Please Enter valid Input!");
                                goto case 1;

                            }
                            else
                            {
                                rectangle.setLength(InputValidation(length));
                                ChoosenMenu = UserMenuSelection();
                            }
                            break;

                        case 3:
                            RectangleWidth = rectangle.GetWidth();
                            Console.WriteLine("The Rectangle width is: {0}", RectangleWidth);
                            ChoosenMenu = UserMenuSelection();
                            break;

                        case 4:
                            Console.WriteLine("Please enter rectangle width: ");
                            string width = Console.ReadLine();
                            if (InputValidation(width) == 0)
                            {
                                Console.WriteLine("Please Enter valid Input!");
                                goto case 4;
                            }
                            else
                            {
                                rectangle.setWidth(InputValidation(width));

                                ChoosenMenu = UserMenuSelection();
                            }
                            break;

                        case 5:
                            int RectanglePerimeter = rectangle.GetPerimeter();
                            Console.WriteLine("The perimeter of Rectangle is: {0}", RectanglePerimeter);
                            ChoosenMenu = UserMenuSelection();
                            break;
                        case 6:
                            int RectangleArea = rectangle.GetArea();
                            Console.WriteLine("The area of Rectangle is: {0}", RectangleArea);
                            ChoosenMenu = UserMenuSelection();
                            break;

                        case 7:
                            Console.WriteLine("You are exiting the program");
                            break;

                    }
                }
            }

            catch(Exception e)
            {
                Console.WriteLine("Following exception occured: {0}", e.Message);
            }

            Console.WriteLine("Program Ended!"); 
        }
    }
}
