namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            do
            {
                Console.WriteLine("\n*********************************");
                Console.WriteLine("Use the numbers to choose an option below.");
                Console.WriteLine("1. Get price based on your age.");
                Console.WriteLine("2. Choice number 2.");
                Console.WriteLine("3. Choice number 3.");
                Console.WriteLine("0. Exit.");
                Console.WriteLine("*********************************");
                Console.WriteLine("\n Enter your choice: ");
                Console.Write("\n> ");

                int input;
                bool mainMenuChoiceParseSuccess = int.TryParse(Console.ReadLine(), out input);

                if (mainMenuChoiceParseSuccess)
                {
                    switch (input)
                    {
                        case 0:
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("\nExiting, see you next time!");
                            Console.ResetColor();
                            running = false;
                            break;
                        case 1:
                            Console.WriteLine("\n*********************************");
                            Console.WriteLine("Pricing by age");
                            Console.WriteLine("Enter your age below: ");
                            Console.Write("> ");

                            int ageInput;
                            bool ageParseSuccess = int.TryParse(Console.ReadLine(), out ageInput);

                            if(ageParseSuccess)
                            {
                                if(ageInput < 20)
                                {
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine("Ungdomspris: 80kr");
                                    Console.ResetColor();
                                } else if (ageInput > 64)
                                {
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine("Pensionärspris: 90kr");
                                    Console.ResetColor();
                                } else
                                {
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine("Standardpris: 120kr");
                                    Console.ResetColor();
                                }
                            } 
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nCould not understand the command, try again using only numbers!");
                                Console.ResetColor();
                            }


                            Console.WriteLine("*********************************");
                            break;
                        case 2:
                            Console.WriteLine("\n*********************************");
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("Menu option 2 takes your here.");
                            Console.ResetColor();
                            break;
                        case 3:
                            Console.WriteLine("\n*********************************");
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("Menu option 3 takes your here.");
                            Console.ResetColor();
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nNo command matches that input, try agan!");
                            Console.ResetColor();
                            break;

                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nCould not understand the command, try again using only numbers!");
                    Console.ResetColor();
                }

               
                

                
            }
            while (running);
        }
    }
}
