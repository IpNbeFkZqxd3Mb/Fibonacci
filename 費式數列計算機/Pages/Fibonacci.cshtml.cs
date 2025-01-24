using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace 費式數列計算機.Pages
{
    public class FibonacciModel : PageModel
    {
        [BindProperty]
        public int Number { get; set; }

        public long? Result { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (Number < 0)
            {
                ModelState.AddModelError("Number", "請輸入大於或等於0的數字！");
                return Page();
            }

            Result = Fibonacci(Number);
            return Page();
        }

        private long Fibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
