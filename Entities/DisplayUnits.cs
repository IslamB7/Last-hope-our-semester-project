using System;
using System.Collections.Generic;
using ResQFlow.Entities;

namespace ResQFlow
{
    class Program
    {
        static void DisplayUnits(string[] args)
        {
            List<EmergencyUnit> units = new List<EmergencyUnit>
            {
                new EmergencyUnit
                {
                    Id = 1,
                    Name = "Ambulance 1",
                    Type = UnitType.Ambulance
                },
                new EmergencyUnit
                {
                    Id = 2,
                    Name = "Firetruck 1",
                    Type = UnitType.Firetruck,
                    Status = UnitStatus.Busy
                },
                new EmergencyUnit
                {
                    Id = 3,
                    Name = "Police Car 1",
                    Type = UnitType.PoliceCar
                }
            };

            // Display available units
            Console.WriteLine("\nAvailable Units:");

            foreach (EmergencyUnit unit in units)
            {
                if (unit.Status == UnitStatus.Available)
                {
                    Console.WriteLine($"{unit.Id}. {unit.Name} - {unit.Type}");
                }
            }

            // Display busy units
            Console.WriteLine("\nBusy Units:");

            foreach (EmergencyUnit unit in units)
            {
                if (unit.Status == UnitStatus.Busy)
                {
                    Console.WriteLine($"{unit.Id}. {unit.Name} - {unit.Type}");
                }
            }
        }
    }
}