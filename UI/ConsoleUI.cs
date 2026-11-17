using System;
using ResQFlow.Entities;

namespace ResQFlow.UI
{
    public class ConsoleUI
    {
        public IncidentType AskIncidentType()
        {
            while (true)
            {
                Console.WriteLine("Incident type:");
                Console.WriteLine("1. Medical");
                Console.WriteLine("2. Fire");
                Console.WriteLine("3. Police");
                Console.Write("Choose a number: ");
                string input = Console.ReadLine();
                int choice;
                bool isNumber = int.TryParse(input, out choice);
                if (isNumber == false)
                {
                    Console.WriteLine("Please type a number.");
                    continue;
                }
                if (choice == 1)
                {
                    return IncidentType.Medical;
                }
                else if (choice == 2)
                {
                    return IncidentType.Fire;
                }
                else if (choice == 3)
                {
                    return IncidentType.Police;
                }
                Console.WriteLine("That number is not in the list.");
            }
        }
        public IncidentPriority AskIncidentPriority()
        {
            while (true)
            {
                Console.WriteLine("Priority:");
                Console.WriteLine("1. Low");
                Console.WriteLine("2. Medium");
                Console.WriteLine("3. High");
                Console.WriteLine("4. Critical");
                Console.Write("Choose a number: ");

                string input = Console.ReadLine();
                int choice;

                if (int.TryParse(input, out choice))
                {
                    if (choice == 1)
                    {
                        return IncidentPriority.Low;
                    }
                    else if (choice == 2)
                    {
                        return IncidentPriority.Medium;
                    }
                    else if (choice == 3)
                    {
                        return IncidentPriority.High;
                    }
                    else if (choice == 4)
                    {
                        return IncidentPriority.Critical;
                    }
                }

                Console.WriteLine("Invalid choice, try again.");
            }
        }
        public string AskRequiredText(string label)
        {
            while (true)
            {
                Console.Write(label + ": ");
                string input = Console.ReadLine();

                if (input != null && input.Trim() != "")
                {
                    return input.Trim();
                }

                Console.WriteLine(label + " cannot be empty.");
            }
        }
    }
}

