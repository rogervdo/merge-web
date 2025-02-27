using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages;

public class PrivacyEmilio : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;

    public PrivacyEmilio(ILogger<PrivacyModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

