using Microsoft.AspNetCore.Mvc;
using MyShop.Utils;

namespace MyShop.Controllers
{
    public class CartController : Controller
    {
        // Действие для очистки корзины
        [HttpPost]
        public IActionResult ClearCart()
        {
            // Очистка корзины
            CartHelper.ClearCart(HttpContext.Session);

            // Перенаправляем пользователя обратно на страницу корзины
            return RedirectToAction("Index");
        }

        // Действие для отображения корзины
        public IActionResult Index()
        {
            var cart = CartHelper.GetCart(HttpContext.Session);
            return View(cart);  // Возвращаем представление с корзиной
        }
    }
}
