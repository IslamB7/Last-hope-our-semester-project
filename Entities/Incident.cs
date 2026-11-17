namespace ResQFlow.Entities
{
    public class Incident()
    {
        public int Id { get; set; }

        public IncidentType? type { get; set; }

        public string Location { get; set; }

        public string Description { get; set; }

        public IncidentPriority? priority { get; set; }

        public IncidentStatus status = IncidentStatus.Incoming;
    }
}
