namespace AgentManager.WebApp.Models.Data
{
    public class District
    {
        public int DistrictID { get; set; }
        public string? DistrictName { get; set; }
        public ICollection<Agent>? Agents { get; set; }
    }
}
