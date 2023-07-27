namespace AgentManager.WebApp.Models.Data
{
    public class Position
    {
        public int PositionId { get; set; }
        public string? PositionName { get; set; }
        public ICollection<Staff>? Staffs { get; set; }
    }
}
