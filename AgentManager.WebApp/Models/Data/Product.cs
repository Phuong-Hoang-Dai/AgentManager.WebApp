namespace AgentManager.WebApp.Models.Data
{
    public class Product
    {
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public string? Image { get; set; }
        public int Price { get; set; }
        public int ProductWeight { get; set; }
        public string ItemUnit { get; set; }
        public int InventoryQuantity { get; set; }
        public int ProductCategoryId { get; set; }
        public ProductCategory? ProductCategory { get; set; }
        public ICollection<DeliveryNoteDetail>? DeliveryNoteDetails { get; set; }
    }
}
