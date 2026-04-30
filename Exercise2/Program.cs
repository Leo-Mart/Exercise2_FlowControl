namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            do
            {
                Console.WriteLine("\n*******************************");
                Console.WriteLine("Use the numbers to choose an option below.");
                Console.WriteLine("1. Choice number 1.");
                Console.WriteLine("2. Choice number 2.");
                Console.WriteLine("3. Choice number 3.");
                Console.WriteLine("0. Exit.");
                Console.WriteLine("*********************************");
                Console.WriteLine("\n Enter your choice: ");
                Console.Write("\n> ");

                int input;
                bool parseSuccess = int.TryParse(Console.ReadLine(), out input);

                if (parseSuccess)
                {
                    switch (input)
                    {
                        case 0:
                            Console.WriteLine("Exiting, see you next time!");
                            running = false;
                            break;
                        case 1:
                            Console.WriteLine("Menu option 1 takes your here.");
                            break;
                        case 2:
                            Console.WriteLine("Menu option 2 takes your here.");
                            break;
                        case 3:
                            Console.WriteLine("Menu option 3 takes your here.");
                            break;
                        default:
                            Console.WriteLine("No command matches that input, try agan!");
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("Could not understand the command, try again, use only numbers!");
                }

               
                

                
            }
            while (running);
        }
    }
}
