using System;
using ResQFlow.Entities;
using ResQFlow.Logic;

namespace ResQFlow.UI
{
    //Class that asks all the information related to the incident, to then send it to be stored in IncidentServices.cs
    public class ConsoleUI
    {
        //Method that returns an incident with all the dispatcher's given information
        public Incident RegisterNewIncident()
        {
            Incident incident = new Incident();
            incident.Status = IncidentStatus.Incoming;

            Console.WriteLine("Type of emergency \n 1. Medical \n 2. Fire \n 3. Police \n Choose: ");
            bool hasType = false;
            while (hasType == false)
            {
                string inputType = Console.ReadLine();
                if (inputType == "1")
                {
                    incident.Type = IncidentType.Medical;
                    hasType = true;
                }
                else if (inputType == "2")
                {
                    incident.Type = IncidentType.Fire;
                    hasType = true;
                }
                else if (inputType == "3")
                {
                    incident.Type = IncidentType.Police;
                    hasType = true;
                }
                else
                {
                    Console.WriteLine("Choose again: ");
                }
            }

            Console.WriteLine("Location of emergency: ");
            string inputLocation = Console.ReadLine();
            incident.Location = inputLocation;

            Console.WriteLine("Short description of emergency: ");
            string inputDescription = Console.ReadLine();
            incident.Description = inputDescription;

            Console.WriteLine("Priority level of emergency \n 1. Low \n 2. Medium \n 3. High \n 4. Critical \n Choose: ");
            bool hasPriority = false;
            while (hasPriority == false)
            {
                string inputPriority = Console.ReadLine();
                if (inputPriority == "1")
                {
                    incident.Priority = IncidentPriority.Low;
                    hasPriority = true;
                }
                else if (inputPriority == "2")
                {
                    incident.Priority = IncidentPriority.Medium;
                    hasPriority = true;
                }
                else if (inputPriority == "3")
                {
                    incident.Priority = IncidentPriority.High;
                    hasPriority = true;
                }
                else if (inputPriority == "4")
                {
                    incident.Priority = IncidentPriority.Critical;
                    hasPriority = true;
                }
                else
                {
                    Console.WriteLine("Choose again: ");
                }
            }

            return incident;
        }
    }
}
