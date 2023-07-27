namespace AgentManager.WebApp.Models.Data
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string? DepartmentName { get; set; }
        public ICollection<Staff>? Staffs { get; set; }
    }
}
