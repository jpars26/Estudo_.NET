using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace WebApplication2.Pages
{
    public class ContactModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            string dateTime = DateTime.Now.ToShortDateString();
            ViewData["TimeStamp"] = dateTime;
        }
    }
}
