using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using System.Text;
using System.Threading.Tasks;

[AllowAnonymous]
public class ConfirmEmailModel : PageModel
{
    private readonly UserManager<IdentityUser> _userManager;
    private readonly ILogger<ConfirmEmailModel> _logger;

    public ConfirmEmailModel(UserManager<IdentityUser> userManager, ILogger<ConfirmEmailModel> logger)
    {
        _userManager = userManager;
        _logger = logger;
    }

    [TempData]
    public string StatusMessage { get; set; }

    public async Task<IActionResult> OnGetAsync(string userId, string code)
    {
        if (userId == null || code == null)
        {
            StatusMessage = "Invalid email confirmation request.";
            _logger.LogError("Invalid email confirmation request.");
            return Page();
        }

        var user = await _userManager.FindByIdAsync(userId);
        if (user == null)
        {
            StatusMessage = $"Unable to load user with ID '{userId}'.";
            _logger.LogError($"Unable to load user with ID '{userId}'.");
            return Page();
        }

        code = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(code)); // Decode the code
        var result = await _userManager.ConfirmEmailAsync(user, code);
        if (result.Succeeded)
        {
            StatusMessage = "Thank you for confirming your email.";
            _logger.LogInformation("Email confirmed successfully for user ID '{userId}'.");
        }
        else
        {
            StatusMessage = "Error confirming your email.";
            _logger.LogError($"Error confirming email for user ID '{userId}': {result.Errors.FirstOrDefault()?.Description}");
        }
        return Page();
    }
}
