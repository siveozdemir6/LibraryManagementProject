using LibraryManagementProject.Repositories;
using LibraryManagementProject.ViewModels.LoginUser;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementProject.Controllers
{
        public class LoginUserController : BaseController
        {
            //[GET]Login page
            [HttpGet]
            public IActionResult Login()
            {
                if (HttpContext.Session.GetString("Username") != null)
                {
                    return RedirectToAction("Index", "Admin"); // If user is already logged in, redirect to admin panel
                }
                return View();
            }
            //[POST] Login form submit
            [HttpPost]
            public IActionResult Login(LoginFormViewModel model)
            {
                if (!ModelState.IsValid)
                {
                    return View(model); // Return the view with validation errors
                }

                var user = LoginUserRepository.Users
                    .FirstOrDefault(u => u.Username == model.Username && u.Password == model.Password); // Check if the user exists with the provided username and password

                if (user != null)
                {
                    HttpContext.Session.SetString("Username", user.Username); //Stores the username in session to maintain login state
                    return RedirectToAction("Index", "Admin"); // Redirect to admin panel after successful login
                }

                ViewBag.ErrorMessage = "Invalid username or password."; // Set error message for invalid login
                return View(model);
            }
            //[POST] Logout action
            [HttpPost]
            public IActionResult Logout()
            {
                HttpContext.Session.Remove("Username"); // Clear the session
                return RedirectToAction("Login", "LoginUser"); // Redirect to login page after logout
            }
        }
    }


