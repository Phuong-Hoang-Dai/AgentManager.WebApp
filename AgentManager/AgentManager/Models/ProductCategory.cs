namespace AgentManager.WebApp.Models
{
    public class ProductCategory
    {
        public int ProductCategoryId { get; set; }
        public string? ProductCategoryName { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
