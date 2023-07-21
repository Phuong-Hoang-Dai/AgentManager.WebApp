namespace AgentManager.WebApp.Models
{
    public class Position
    {
        public int PositionId { get; set; }
        public string? PositionName { get; set; }
        public ICollection<Staff>? Staffs { get; set;}
    }
}
