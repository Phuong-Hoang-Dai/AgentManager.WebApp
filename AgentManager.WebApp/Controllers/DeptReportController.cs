using AgentManager.WebApp.Models.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Security.Principal;

namespace AgentManager.WebApp.Controllers
{

    public class DeptReportController : Controller
    {
        private readonly AgentManagerDbContext _context;
        public DeptReportController(AgentManagerDbContext context, AgentManagerDbContext context1)
        {
            _context = context;
        }

        // GET: Agent
        public async Task<IActionResult> Index()

        {

            var agentManagerDbContext = _context.Agents.Include(a => a.AgentCategory).Include(a => a.District);
            return View(await agentManagerDbContext.ToListAsync());
        }
        // GET: Agent/Details/5
        public async Task<IActionResult> Details(int? id)
        {
           

            if (id == null || _context.Agents == null)
                {
                    return NotFound();
                }
                     

                var agent = await _context.Agents
                    .Include(a => a.AgentCategory)
                    .Include(a => a.District)
                    .Include(a => a.DeliveryNotes)
                    .ThenInclude(b => b.Staff)
                    .FirstOrDefaultAsync(m => m.AgentId == id);


            if (agent == null)
                {
                    return NotFound();
                }

            decimal totalPrice = agent.DeliveryNotes.Sum(dn => dn.TotalPrice);
            ViewBag.TotalPrice = totalPrice;

            return View(agent);
            
        }
       

    }
}
