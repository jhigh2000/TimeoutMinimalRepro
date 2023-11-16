using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages;

public class PrivacyModel : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;

    public PrivacyModel(ILogger<PrivacyModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        // set a breakpoint here and wait to simulate a long debug session
        var s0 = 0;
    }
}
