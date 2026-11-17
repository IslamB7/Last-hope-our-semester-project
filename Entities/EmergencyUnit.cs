namespace ResQFlow.Entities
{
    public class EmergencyUnit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public UnitType Type { get; set; }
        public UnitStatus Status { get; set; } = UnitStatus.Available;
    }
}