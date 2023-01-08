using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using WebAppProject.Data;
using WebAppProject.Model;

namespace WebAppProject.Pages
{
    public class ProblemReportModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            var content = Request.Form["content"];
            var category = Request.Form["category"];
            var nickname = Request.Form["nickname"];

            var report = new ReportProblem
            {
                content = content,
                category = category,
                nickname = nickname
            };

            _context.ReportProblems.Add(report);
            _context.SaveChanges();

            return RedirectToPage("index");
        }

        public ProblemReportModel(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
