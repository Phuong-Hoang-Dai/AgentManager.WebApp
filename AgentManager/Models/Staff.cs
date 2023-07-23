using Microsoft.AspNetCore.Identity;

namespace AgentManager.WebApp.Models
{
    public class Staff : IdentityUser
    {
        public string? StaffName { get; set; }
        public string? Gender { get; set; }
        public DateTime DoB { get; set; }
        public string? Address { get; set; }
        public int DepartmentId { get; set; }
        public Department? Department{ get; set; }
        public int PositionId { get; set; }
        public Position? Position{ get; set; }
        public ICollection<Receipt>? Receipts { get; set; }
        public ICollection<DeliveryNote>? DeliveryNotes { get; set; }
    }
}
