﻿namespace AgentManager.WebApp.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string? DepartmentName { get; set; }
        //public int StaffID { get; set; }
        public ICollection<Staff>? Staffs { get; set; }
    }
}
