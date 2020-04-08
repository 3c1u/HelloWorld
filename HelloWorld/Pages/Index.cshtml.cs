using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HelloWorld.Pages
{
    public class IndexModel : PageModel
    {
        public string Message = "";
        public string Answer = "";
        public bool IsCorrect => Answer == "仙狐";

        public void OnGet()
        {
            string answer = Request.Query["answer"];
            Answer = answer;

            if (IsCorrect)
            {
                Message = "正解";
            }
            else
            {
                Message = "不正解";
            }
        }
    }
}
