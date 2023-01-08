using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppProject.Areas.Identity.Data;
using WebAppProject.Data;
using WebAppProject.Model;

namespace WebAppProject.Pages
{

    public class RankingModel : PageModel
    {
        public List<ApplicationUser> UserInfo = new List<ApplicationUser>();

        private readonly ApplicationDbContext _context;
        public RankingModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            UserInfo = _context.Users.ToList();
        }
    }

}
