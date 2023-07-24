using AgentManager.WebApp.Models;

namespace AgentManager.Models.ViewModel
{
    public class AddAgentViewModel
    {
        public string? AgentName { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public int DistrictId { get; set; }
        public District? District { get; set; }
        public int AgentCategoryId { get; set; }
        public AgentCategory? AgentCategory { get; set; }
    }
}
