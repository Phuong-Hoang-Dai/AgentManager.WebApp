namespace AgentManager.WebApp.Models.Data
{
    public class AgentCategory
    {
        public int AgentCategoryId { get; set; }
        public int MaxDebt { get; set; }
        public ICollection<Agent>? Agents { get; set; }
    }
}
