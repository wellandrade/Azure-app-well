using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Azure_app_well.Pages
{
    public class PrivacyModel : PageModel
    {
        public void OnGet()
        {
            throw new Exception("This is a test exception for Azure Application Insights.");
        }
    }

}
