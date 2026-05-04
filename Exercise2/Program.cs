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
                            bool showPriceMenu = true;
                            do
                            {
                                Console.WriteLine("\n*********************************");
                                Console.WriteLine("Pricing by age");
                                Console.WriteLine("Enter '0' to go back to the main menu.");
                                Console.WriteLine("Enter your age below: ");
                                Console.Write("> ");


                                bool ageParseSuccess = int.TryParse(Console.ReadLine(), out int ageInput);

                                if (ageParseSuccess)
                                {
                                    if (ageInput == 0)
                                    {
                                        showPriceMenu = false;
                                    }
                                    else if (ageInput <= 5 || ageInput >= 100)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.WriteLine("Free!");
                                        Console.ResetColor();
                                        showPriceMenu = false;
                                    }
                                    else if (ageInput <= 20)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.WriteLine("Ungdomspris: 80kr");
                                        Console.ResetColor();
                                        showPriceMenu = false;

                                    }
                                    else if (ageInput >= 64)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.WriteLine("Pensionärspris: 90kr");
                                        Console.ResetColor();
                                        showPriceMenu = false;

                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.WriteLine("Standardpris: 120kr");
                                        Console.ResetColor();
                                        showPriceMenu = false;
                                    }
                                }
                                else
                                {
                                    PrintError("No command matches that input, try agan!");
                                }

                                Console.WriteLine("*********************************");
                            }
                            while (showPriceMenu);
                            break;
                        case 2:
                            bool showGroupPriceMenu = true;
                            do
                            {
                                Console.WriteLine("\n*********************************");
                                Console.WriteLine("Get price for a group or party");
                                Console.WriteLine("Enter '0' to go back to the main menu.");
                                Console.WriteLine("Enter the size of the group: ");
                                Console.Write("> ");

                                bool groupSizeParseSuccess = int.TryParse(Console.ReadLine(), out int groupSizeInput);

                                if (groupSizeParseSuccess)
                                {
                                    if (groupSizeInput == 0)
                                    {
                                        // showGroupPriceMenu = false;
                                        break;
                                    }
                                    int totalPrizeForGroup = 0;

                                    Console.WriteLine($"You've chosen a group size of: {groupSizeInput}");
                                    Console.WriteLine("Now enter the age of each individual: ");

                                    for (int i = 1; i <= groupSizeInput; i++)
                                    {
                                        bool properValue = false;
                                        do
                                        {
                                            Console.Write($"Person nr {i} age > ");
                                            bool groupAgeParseSuccess = int.TryParse(Console.ReadLine(), out int groupAgeInput);

                                            if (groupAgeParseSuccess)
                                            {
                                                if (groupAgeInput <= 5 || groupAgeInput >= 100)
                                                {
                                                    totalPrizeForGroup += 0;
                                                    properValue = true;
                                                }
                                                else if (groupAgeInput <= 20)
                                                {
                                                    totalPrizeForGroup += 80;
                                                    properValue = true;
                                                }
                                                else if (groupAgeInput >= 64)
                                                {
                                                    totalPrizeForGroup += 90;
                                                    properValue = true;
                                                }
                                                else
                                                {
                                                    totalPrizeForGroup += 120;
                                                    properValue = true;
                                                }
                                            }
                                            else
                                            {
                                                PrintError("No command matches that input, try agan!");
                                            }
                                        } while (!properValue);
                                    }

                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine($"The total prize for a group of {groupSizeInput} will be {totalPrizeForGroup} kr");
                                    Console.ResetColor();
                                    showGroupPriceMenu = false;
                                }
                                else
                                {
                                    PrintError("No command matches that input, try agan!");
                                }
                            }
                            while (showGroupPriceMenu);
                            break;
                        case 3:
                            bool showRepeatPhraseMenu = true;
                            do
                            {
                                Console.WriteLine("\n*********************************");
                                Console.WriteLine("Repeat a phrase 10 times");
                                Console.WriteLine("Write 'quit' to return to main menu.");
                                Console.WriteLine("Enter a phrase that should be printed 10 times below: ");
                                Console.Write("\n> ");

                                string? stringInput = Console.ReadLine();

                                if (string.IsNullOrWhiteSpace(stringInput))
                                {
                                    PrintError("Please enter a proper sentence or word");
                                }
                                else if (stringInput == "quit")
                                {
                                    showRepeatPhraseMenu = false;
                                }
                                else
                                {
                                    for (int i = 1; i <= 10; i++)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.Write($"{i}. {stringInput}, ");
                                        if (i == 10)
                                            Console.Write($"{i}. {stringInput}");
                                        Console.ResetColor();
                                    }
                                    showRepeatPhraseMenu = false;
                                }
                            } while (showRepeatPhraseMenu);

                            break;
                        case 4:
                            bool showSplitStringMenu = true;
                            do
                            {
                                Console.WriteLine("\n*********************************");
                                Console.WriteLine("Splitting a string and returning the third word.");
                                Console.WriteLine("Write 'quit' to return to main menu.");
                                Console.WriteLine("Enter a sentence below to split, with a minimum of 3 words:");
                                Console.Write("\n> ");

                                string? sentenceInput = Console.ReadLine();

                                if (string.IsNullOrWhiteSpace(sentenceInput))
                                {
                                    PrintError("Please enter a proper sentence or word");
                                }
                                else if (sentenceInput == "quit")
                                {
                                    showSplitStringMenu = false;
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
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.WriteLine($"The third word is: {splitSentence[2]}");
                                        Console.ResetColor();
                                        showSplitStringMenu = false;
                                    }
                                }
                            } while (showSplitStringMenu);

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
