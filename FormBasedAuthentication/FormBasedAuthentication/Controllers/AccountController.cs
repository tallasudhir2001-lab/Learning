using FormBasedAuthentication.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace FormBasedAuthentication.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            // ❗ Replace this with DB validation
            if (model.Username == "admin" && model.Password == "1234")
            {
                // 1️ Create claims (WHO the user is)
                var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, model.Username),
                new Claim(ClaimTypes.Role, "Admin"), // Role
                new Claim(ClaimTypes.Role, "User")
            };

                // 2️ Create identity (HOW user is authenticated)
                var identity = new ClaimsIdentity(
                    claims,
                    CookieAuthenticationDefaults.AuthenticationScheme
                );

                // 3️ Create principal (USER object)
                var principal = new ClaimsPrincipal(identity);

                // 4️ Create + Encrypt + Sign + Send COOKIE
                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    principal
                );

                return RedirectToAction("Index", "Home");
            }

            ViewBag.Error = "Invalid username or password";
            return View();
        }
        public async Task<IActionResult> Logout()
        {
            // Deletes authentication cookie
            await HttpContext.SignOutAsync(
                CookieAuthenticationDefaults.AuthenticationScheme
            );

            return RedirectToAction("Login");
        }

        public IActionResult AccessDenied()
        {
            return Content("Access Denied");
        }
    }
}
