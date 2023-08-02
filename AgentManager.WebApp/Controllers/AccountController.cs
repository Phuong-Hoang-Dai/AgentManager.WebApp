using AgentManager.WebApp.Models.Data;
using AgentManager.WebApp.Models.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace AgentManager.WebApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<Staff>? _userManager;
        private readonly AgentManagerDbContext _context;
        private readonly RoleManager<IdentityRole> _roleManager;

        [BindProperty]
        [DisplayName("Danh sách các quyền")]
        public string[] roles { get; set; }
        public SelectList allRoles { get; set; }


        public AccountController(AgentManagerDbContext context, UserManager<Staff>? userManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }
        // GET: AccountController
        public async Task<IActionResult> Index()
        {
            return View(await _userManager.Users.Include(x => x.Position)
                .Include(y => y.Department).ToListAsync());
        }
        public async Task<IActionResult> Register(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var s = await _userManager.FindByIdAsync(id);

            if (s == null)
            {
                return NotFound();
            }
            return View();
        }

        [HttpPost, ActionName("Register")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RegisterConfirm(string id)
        {
            var s = await _userManager.FindByIdAsync(id);

            if (s == null)
            {
                return NotFound();
            }
            // await _userManager.RemovePasswordAsync(s);
            var result = await _userManager.AddPasswordAsync(s, "123456"); //$"{s.DoB.Day}{s.DoB.Month}{s.DoB.Year}");
            Console.WriteLine(s.PasswordHash + result);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> AddRole(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var s = await _userManager.FindByIdAsync(id);

            if (s == null)
            {
                return NotFound();
            }

            roles = (await _userManager.GetRolesAsync(s)).ToArray();
            List<string> rolesList = await _roleManager.Roles.Select(r => r.Name).ToListAsync();
            allRoles = new SelectList(rolesList);

            return View();
        }

        [HttpPost, ActionName("AddRole")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddRoles(string id)
        {
            var s = await _userManager.FindByIdAsync(id);

            if (s == null)
            {
                return NotFound();
            }
            // await _userManager.RemovePasswordAsync(s);
            var result = await _userManager.AddPasswordAsync(s, "123456"); //$"{s.DoB.Day}{s.DoB.Month}{s.DoB.Year}");
            Console.WriteLine(s.PasswordHash + result);
            return RedirectToAction(nameof(Index));
        }
        // GET: AccountController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AccountController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
