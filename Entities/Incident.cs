namespace ResQFlow.Entities
{
    public class Incident()
    {
        public int Id { get; set; }

        public IncidentType? Type { get; set; }

        public string Location { get; set; } = string.Empty;

        public string Description = string.Empty;

        public IncidentPriority? Priority { get; set; }

        public IncidentStatus Status { get; set; } = IncidentStatus.Incoming;
    }
}
