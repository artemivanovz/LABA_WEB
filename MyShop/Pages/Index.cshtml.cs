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
            // ������� ������������������ ����
            await HttpContext.SignOutAsync("MyCookieAuth"); // ���������, ��� ��� ����� ������������� ����� ������������

            // �������������� ������������ �� ������� ��������
            return RedirectToPage("Index");
        }
    }
}
