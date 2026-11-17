using System;
using ResQFlow.Entities;
using ResQFlow.Logic;
using ResQFlow.UI;

class ConsoleMenu {

    static IncidentService incidentService = new IncidentService();
    static ConsoleUI ui = new ConsoleUI();
    static void Main(string[] args)
    {
        Run(args);
    }

    static void RegisterIncident()
    {
        IncidentType type = ui.AskIncidentType();
        string location = ui.AskRequiredText("Location");
        string description = ui.AskRequiredText("Description");
        IncidentPriority priority = ui.AskIncidentPriority();
        Incident incident = incidentService.Register(type, location, description, priority);
        Console.WriteLine("Incident registered with ID " + incident.Id);
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
            RegisterIncident();
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
