using Microsoft.AspNetCore.Mvc;

namespace FreeBooks.Areas.Admin.Controllers;


[Area("Admin")]
public class AccountsController : Controller
{
    // GET
    public IActionResult Login()
    {
        return View();
    }
}