namespace AgentManager.WebApp.Models
{
    public class Agent
    {
        public int AgentId { get; set; }
        public string? Agents { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public DateTime ReceivedDate { get; set; }
        public ICollection<DeliveryNote>? DeliveryNotes { get; set; }
        public ICollection<Receipt>? Receipts { get; set; }
        public int DistrictId { get; set; }
        public District? District { get; set; }
        public int AgentCategoryId { get; set; }
        public AgentCategory? AgentCategory { get; set; }
    }
}
