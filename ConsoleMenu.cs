using System;

namespace ResQFlow.UI;

class ConsoleMenu {

    public void Run() {

    Console.WriteLine("""
        Menu:

        [1] Register New Incident
        [2] View Active Incidents
        [3] View Available Units
        [4] View Completed Incidents
        [5] Help
        [6] End Shift

        """);

    static int MenuSelection() {

        bool correct = true;
        int menuChoice = 0;

        do {
            Console.Write("Enter a number from the menu: ");
            
            correct = int.TryParse(Console.ReadLine(), out menuChoice);

            if (!correct || menuChoice < 1 || menuChoice > 6) {
                Console.WriteLine("Invalid input - try again");
                correct = false;
            } else {
                correct = true;
            }
        } while (correct == false);

        return menuChoice;
    }

        switch (MenuSelection()) {
            case 1:
            Console.WriteLine("'Register New Incident' selected");
            break;

            case 2:
            Console.WriteLine("'View Active Incidents' selected");
            break;

            case 3:
            Console.WriteLine("'View Available Units' selected");
            break;

            case 4:
            Console.WriteLine("'View Completed Incidents' selected");
            break;

            case 5:
            Console.WriteLine("'Help' selected");
            break;

            case 6:
            Console.WriteLine("'End Shift' selected");
            break;
        }
    }
}