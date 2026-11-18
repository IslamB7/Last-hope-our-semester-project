using System;
using ResQFlow.Entities;
using ResQFlow.UI;

namespace ResQFlow.Logic
{
    //Class that stores the list with the incidents registered during the dispatcher's shift, class that manages the incidents
    public class IncidentService
    {
        //List that stores all the incidents registered by the dispatcher
        private List<Incident> incidents = new List<Incident>();
        //Private integer only accessed by IncidentService so that no other part of the system alters the numbered list
        private int newId = 1;

        //Method that adds a new incident to the incidents list and a gives it an id number
        public void AddIncident(Incident incident)
        {
            incident.Id = newId;
            newId++;
            incidents.Add(incident);
        }

        //Method that returns list with all the active incidents
        public List<Incident> GetActiveIncidents()
        {
            return incidents;
        }
    }
}