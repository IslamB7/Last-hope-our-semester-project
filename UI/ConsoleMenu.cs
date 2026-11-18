using System;
using ResQFlow.UI;
using ResQFlow.Logic;
using ResQFlow.Entities;

class ConsoleMenu {
    //Creates a shared IncidentService for the whole dispatcher's shift, to be able to use the same incidents list
    static IncidentService incidentService = new IncidentService();
    static void Main(string[] args)
    {
        Run(args);
    }
    static void Run(string[] args) {

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
            try {
                menuChoice = int.Parse(Console.ReadLine());
            }
            catch (FormatException) {
            }

            if (menuChoice < 1 || menuChoice > 6) {
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
            //Creates the user interface to collect information from the user, for each new selection of this case
            ConsoleUI consoleUI = new ConsoleUI();
            //Creates a new incident with the information given by the dispatcher
            Incident incident = consoleUI.RegisterNewIncident();
            //Stores the returned incident in incident list and gives it an id
            incidentService.AddIncident(incident);
            Console.WriteLine("Incident ID: " + incident.Id);
            break;

            case 2:
            Console.WriteLine("'View Active Incidents' selected");
            break;

            case 3:
            Console.WriteLine("'View Completed Incidents' selected");
            break;

            case 4:
            Console.WriteLine("'View Available Units' selected");
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
