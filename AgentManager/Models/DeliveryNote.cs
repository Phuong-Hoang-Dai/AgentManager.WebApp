namespace AgentManager.WebApp.Models
{
    public class DeliveryNote
    {
        public int DeliveryNoteId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int TotalPrice { get; set; }
        public int Payment { get; set; }
        public ICollection<DeliveryNoteDetail>? DeliveryNoteDetails { get; set; }
        public int AgentId { get; set; }
        public Agent? Agent { get; set; }
        public string? StaffId { get; set; }
        public Staff? Staff { get; set; }
    }
}
