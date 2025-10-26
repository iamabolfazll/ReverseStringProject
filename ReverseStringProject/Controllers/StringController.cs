using Microsoft.AspNetCore.Mvc;
using Contracts;

namespace ReverseStringProject.Controllers
{
    public class StringController : Controller
    {
        private readonly IStringService _stringService;

        public StringController(IStringService stringService)
        {

            _stringService = stringService;
        }

        public IActionResult ReverseString()
        {
            ViewBag.IsPalindrome = false; // 🔹 مقدار پیش‌فرض
            return View();
        }

        [HttpPost]
        public IActionResult ReverseString(string inputText)
        {
            try
            {
                if (string.IsNullOrEmpty(inputText))
                {
                    ViewBag.Error = "لطفا یک رشته وارد کنید";
                    return View();
                }

                string reversed = _stringService.ReverseString(inputText);
                bool isPalindrome = _stringService.IsPalindrome(inputText);

                ViewBag.Original = inputText;
                ViewBag.Reversed = reversed;
                ViewBag.IsPalindrome = isPalindrome;
                ViewBag.Success = true;
            }
            catch (Exception ex)
            {
                ViewBag.Error = $"خطا: {ex.Message}";
            }

            return View();
        }
    }
}