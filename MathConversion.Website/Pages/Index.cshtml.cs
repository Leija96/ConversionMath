using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using MathConversion.Website.Services;
using System.Threading.Tasks;
using MathConversion.Website.Models;

namespace MathConversion.Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFileProblemService ProblemService;
        public IEnumerable<Problem> Problem { get; private set; }
        

        public IndexModel(ILogger<IndexModel> logger, JsonFileProblemService problemService)
        {
            _logger = logger;
            ProblemService = problemService;
        }

        public void OnGet()
        {
            Problem = ProblemService.GetProblem();
        }
    }
}
