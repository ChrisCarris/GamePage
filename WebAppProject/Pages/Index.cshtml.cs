using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebAppProject.Areas.Identity.Data;
using WebAppProject.Data;

namespace WebAppProject.Pages
{   
    public class IndexModel : PageModel
    {
        public ApplicationUser LoggedInUser = new ApplicationUser();
        private readonly ILogger<IndexModel> _logger;
        private readonly ApplicationDbContext _context;
        public bool IsListVisible;
        public IndexModel(ILogger<IndexModel> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public void OnGet()
        {
            if(HttpContext?.User?.Identity is null)
            {
                IsListVisible = false;
                return;
            }
            IsListVisible = _context.Users.FirstOrDefault(u => u.UserName == HttpContext.User.Identity.Name)?.AccountPermissions==100;
        }
    }
}