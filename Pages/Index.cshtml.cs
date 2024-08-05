using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace DayOfYearApp.Pages
{
    public class IndexModel : PageModel
    {
        public int DayOfYear { get; private set; }

        public void OnGet()
        {
            DayOfYear = DateTime.Now.DayOfYear;
        }
    }
}