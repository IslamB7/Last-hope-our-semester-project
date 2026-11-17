namespace ResQFlow.Entities
{
    public class Incident()
    {
        public int Id { get; set; }

        public IncidentType? type { get; set; }

        public string Location = string.Empty;

        public string Description = string.Empty;

        public IncidentPriority? priority { get; set; }

        public IncidentStatus status { get; set; } = IncidentStatus.Incoming;
    }
}
