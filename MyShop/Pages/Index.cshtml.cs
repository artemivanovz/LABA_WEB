using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyShop.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPostAsync()
        {
            // Удаляем аутентификационную куку
            await HttpContext.SignOutAsync("MyCookieAuth"); // Убедитесь, что имя схемы соответствует вашей конфигурации

            // Перенаправляем пользователя на главную страницу
            return RedirectToPage("Index");
        }
    }
}
