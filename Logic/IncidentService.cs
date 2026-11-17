using System;
using System.Collections.Generic;
using ResQFlow.Entities;

namespace ResQFlow.Logic
{
    public class IncidentService
    {
        private List<Incident> incidents = new List<Incident>();
        private int nextId = 1;

        public List<Incident> GetAll()
        {
            return incidents;
        }

        public Incident Register(IncidentType type, string location, string description, IncidentPriority priority)
        {
            Incident incident = new Incident();
            incident.Id = nextId;
            incident.Type = type;
            incident.Location = location;
            incident.Description = description;
            incident.Priority = priority;
            nextId = nextId + 1;
            incidents.Add(incident);
            return incident;
        }
    }
}