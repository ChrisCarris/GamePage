using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppProject.Areas.Identity.Data;
using WebAppProject.Data;
using WebAppProject.Model;

namespace WebAppProject.Pages
{
    public class ProblemListModel : PageModel
    {
        public List<ReportProblem> ReportProblems = new List<ReportProblem>();

        private readonly ApplicationDbContext _context;
        public ProblemListModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            ReportProblems = _context.ReportProblems.ToList();
        }
    }
}
