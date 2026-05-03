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
                Console.WriteLine("2. Get price for a group/party.");
                Console.WriteLine("3. Repeat a phrase or word.");
                Console.WriteLine("4. Get the third word of a sentence.");
                Console.WriteLine("0. Exit.");
                Console.WriteLine("*********************************");
                Console.WriteLine("\n Enter your choice: ");
                Console.Write("\n> ");

                bool mainMenuChoiceParseSuccess = int.TryParse(Console.ReadLine(), out int input);

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


                            bool ageParseSuccess = int.TryParse(Console.ReadLine(), out int ageInput);

                            if(ageParseSuccess)
                            {
                                if (ageInput <= 5 || ageInput >= 100)
                                {
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine("Free!");
                                    Console.ResetColor();
                                }
                                else if(ageInput <= 20)
                                {
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine("Ungdomspris: 80kr");
                                    Console.ResetColor();
                                }
                                else if (ageInput >= 64)
                                {
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine("Pensionärspris: 90kr");
                                    Console.ResetColor();
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine("Standardpris: 120kr");
                                    Console.ResetColor();
                                }
                            } 
                            else
                            {
                                PrintError("No command matches that input, try agan!");
                            }

                            Console.WriteLine("*********************************");
                            break;
                        case 2:
                            Console.WriteLine("\n*********************************");
                            Console.WriteLine("Get price for a group or party");
                            Console.WriteLine("Enter the size of the group: ");
                            Console.Write("> ");

                            bool groupSizeParseSuccess = int.TryParse(Console.ReadLine(), out int groupSizeInput);

                            if(groupSizeParseSuccess)
                            {
                                int totalPrizeForGroup = 0;                                

                                Console.WriteLine($"You've chosen a group size of: {groupSizeInput}");
                                Console.WriteLine("Now enter the age of each individual: ");

                                for (int i = 1; i <= groupSizeInput; i++)
                                {
                                    Console.Write($"Person nr {i} age > ");
                                    bool groupAgeParseSuccess = int.TryParse(Console.ReadLine(), out int groupAgeInput);

                                    if (groupAgeParseSuccess)
                                    {
                                        if (groupAgeInput <= 5 || groupAgeInput >= 100)
                                        {
                                            totalPrizeForGroup += 0;
                                        }
                                        else if (groupAgeInput <= 20)
                                        {
                                            totalPrizeForGroup += 80;
                                        }
                                        else if (groupAgeInput >= 64)
                                        {
                                            totalPrizeForGroup += 90;
                                        }
                                        else
                                        {
                                            totalPrizeForGroup += 120;                                            
                                        }
                                        
                                    }
                                    else
                                    {
                                        PrintError("No command matches that input, try agan!");
                                    }                                    
                                }

                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine($"The total prize for a group of {groupSizeInput} will be {totalPrizeForGroup} kr");
                                Console.ResetColor();
                            }
                            else
                            {
                                PrintError("No command matches that input, try agan!");
                            }

                            

                            break;
                        case 3:
                            Console.WriteLine("\n*********************************");
                            Console.WriteLine("Repeat a phrase 10 times");
                            Console.WriteLine("Enter a phrase that should be printed 10 times below: ");
                            Console.Write("\n> ");

                            string? stringInput = Console.ReadLine();

                            if (string.IsNullOrWhiteSpace(stringInput))
                            {
                                PrintError("Please enter a proper sentence or word");
                            } else
                            {
                                for (int i = 1; i <= 10; i++)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write($"{i}. {stringInput}, ");
                                    if (i == 10)
                                        Console.Write($"{i}. {stringInput}");
                                    Console.ResetColor();
                                }
                            }                            
                            break;
                        case 4:
                            Console.WriteLine("\n*********************************");
                            Console.WriteLine("Splitting a string and returning the third word.");
                            Console.WriteLine("Enter a sentence below to split, with a minimum of 3 words:");
                            Console.Write("\n> ");

                            string? sentenceInput = Console.ReadLine();

                            if (string.IsNullOrWhiteSpace(sentenceInput))
                            {
                                PrintError("Please enter a proper sentence or word");
                            }
                            else
                            {
                                var splitSentence = sentenceInput.Split(' ', StringSplitOptions.RemoveEmptyEntries); // Splits the string on the "space" character, while also removing any potential empty entries from the resulting array made while splitting multiple spaces.
                                if (splitSentence.Length < 3)
                                {
                                    PrintError("That sentence is too short, at least 3 words please!");
                                }
                                else
                                {
                                    Console.WriteLine(splitSentence[2]);
                                }
                            }
                            break;

                        default:
                            PrintError("No command matches that input, try agan!");
                            break;
                    }
                }
                else
                {
                    PrintError("No command matches that input, try agan!");
                }
            }
            while (running);
        }

        static void PrintError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n{message}");
            Console.ResetColor();
        }
    }
}
