#nullable disable
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppProject.Areas.Identity.Data;
using WebAppProject.Data;
using WebAppProject.Model;

namespace WebAppProject.Areas.Identity.Pages.Account.Manage
{
    public class IndexModel : PageModel
    {
        public ApplicationUser UserInfo = new ApplicationUser();

        private readonly ApplicationDbContext _context;
        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            UserInfo = _context.Users.FirstOrDefault(u => u.UserName == HttpContext.User.Identity.Name);
        }


    }
}
