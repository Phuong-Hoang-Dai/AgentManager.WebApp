namespace AgentManager.WebApp.Models.Data
{
    public class Agent
    {
        public int AgentId { get; set; }
        public string? AgentName { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public DateTime ReceptionDate { get; set; }
        public ICollection<DeliveryNote>? DeliveryNotes { get; set; }
        public ICollection<Receipt>? Receipts { get; set; }
        public int DistrictId { get; set; }
        public District? District { get; set; }
        public int AgentCategoryId { get; set; }
        public AgentCategory? AgentCategory { get; set; }
    }
}
