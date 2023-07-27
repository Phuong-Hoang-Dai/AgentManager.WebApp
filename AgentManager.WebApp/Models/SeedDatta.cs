using AgentManager.WebApp.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace AgentManager.WebApp.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (AgentManagerDbContext? context = new AgentManagerDbContext(serviceProvider.GetRequiredService<
                    DbContextOptions<AgentManagerDbContext>>()))
            {
                if (!context.AgentCategories.Any())
                {
                    context.AddRange(
                    new AgentCategory
                    {
                        MaxDebt = 20000000
                    },
                    new AgentCategory
                    {
                        MaxDebt = 10000000
                    },
                    new AgentCategory
                    {
                        MaxDebt = 5000000
                    });
                    context.SaveChanges();
                }


                if (!context.Districts.Any())
                {
                    context.AddRange(
                    new District
                    {
                        DistrictName = "Quan 1"
                    },
                    new District
                    {
                        DistrictName = "Quan 2"
                    },
                    new District
                    {
                        DistrictName = "Quan 3"
                    },
                    new District
                    {
                        DistrictName = "Quan 4"
                    },
                    new District
                    {
                        DistrictName = "Quan 5"
                    },
                    new District
                    {
                        DistrictName = "Quan 6"
                    },
                    new District
                    {
                        DistrictName = "Quan 7"
                    },
                    new District
                    {
                        DistrictName = "Quan 8"
                    },
                    new District
                    {
                        DistrictName = "Quan 9"
                    },
                    new District
                    {
                        DistrictName = "Quan 10"
                    },
                    new District
                    {
                        DistrictName = "Quan 11"
                    },
                    new District
                    {
                        DistrictName = "Quan 12"
                    });
                    context.SaveChanges();
                }

                if (!context.Agents.Any())
                {
                    context.AddRange(
                    new Agent
                    {
                        AgentName = "Hai Nam",
                        Address = "18 Ly Thuong Kiet P5 Q10",
                        Phone = "626-527-1165",
                        ReceptionDate = new DateTime(2023, 5, 10),
                        DistrictId = 10,
                        AgentCategoryId = 1
                    },
                    new Agent
                    {
                        AgentName = "Hong Phuong",
                        Address = "20 Tran Hung Dao P6 Q5",
                        Phone = "858-416-0537",
                        ReceptionDate = new DateTime(2023, 2, 9),
                        DistrictId = 5,
                        AgentCategoryId = 2
                    },
                    new Agent
                    {
                        AgentName = "Kien",
                        Address = "28 Phan Van Tri P2 Q7",
                        Phone = "212-962-7488",
                        ReceptionDate = new DateTime(2023, 2, 9),
                        DistrictId = 7,
                        AgentCategoryId = 3
                    },
                    new Agent
                    {
                        AgentName = "Kien",
                        Address = "28 Phan Van Tri P2 Q7",
                        Phone = "212-962-7488",
                        ReceptionDate = new DateTime(2023, 2, 9),
                        DistrictId = 7,
                        AgentCategoryId = 3
                    },
                    new Agent
                    {
                        AgentName = "Kien",
                        Address = "28 Phan Van Tri P2 Q7",
                        Phone = "212-962-7488",
                        ReceptionDate = new DateTime(2023, 2, 9),
                        DistrictId = 7,
                        AgentCategoryId = 3
                    },
                    new Agent
                    {
                        AgentName = "Kien",
                        Address = "28 Phan Van Tri P2 Q7",
                        Phone = "212-962-7488",
                        ReceptionDate = new DateTime(2023, 2, 9),
                        DistrictId = 7,
                        AgentCategoryId = 3
                    },
                    new Agent
                    {
                        AgentName = "Kien",
                        Address = "28 Phan Van Tri P2 Q7",
                        Phone = "212-962-7488",
                        ReceptionDate = new DateTime(2023, 2, 9),
                        DistrictId = 7,
                        AgentCategoryId = 3
                    },
                    new Agent
                    {
                        AgentName = "Kien",
                        Address = "28 Phan Van Tri P2 Q7",
                        Phone = "212-962-7488",
                        ReceptionDate = new DateTime(2023, 2, 9),
                        DistrictId = 7,
                        AgentCategoryId = 3
                    },
                    new Agent
                    {
                        AgentName = "Kien",
                        Address = "28 Phan Van Tri P2 Q7",
                        Phone = "212-962-7488",
                        ReceptionDate = new DateTime(2023, 2, 9),
                        DistrictId = 7,
                        AgentCategoryId = 3
                    },
                    new Agent
                    {
                        AgentName = "Kien",
                        Address = "28 Phan Van Tri P2 Q7",
                        Phone = "212-962-7488",
                        ReceptionDate = new DateTime(2023, 2, 9),
                        DistrictId = 7,
                        AgentCategoryId = 3
                    },
                    new Agent
                    {
                        AgentName = "Kien",
                        Address = "28 Phan Van Tri P2 Q7",
                        Phone = "212-962-7488",
                        ReceptionDate = new DateTime(2023, 2, 9),
                        DistrictId = 7,
                        AgentCategoryId = 3
                    });
                    context.SaveChanges();
                }

            }
        }
    }
}
