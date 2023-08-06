using MessagePack;

namespace AgentManager.WebApp.Models.Data
{
    public class DeliveryNoteDetail
    {
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }
        public int DeliveryNoteId { get; set; }
        public DeliveryNote? DeliveryNote { get; set; }
    }
}
