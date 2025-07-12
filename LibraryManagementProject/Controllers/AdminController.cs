using LibraryManagementProject.Repositories;
using LibraryManagementProject.ViewModels.Admin;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementProject.Controllers
{
    public class AdminController : BaseController
    {
        //This action displays the admin panel if the user is logged in
        public IActionResult Index()
        {
            var username = HttpContext.Session.GetString("Username"); // Retrieve the username from session

            if (string.IsNullOrEmpty(username))
            {
                TempData["ErrorMessage"] = "Bu sayfaya erişmek için önce giriş yapmalısınız."; //Error message to access admin panel
                return RedirectToAction("Login", "LoginUser"); // If not logged in, redirect to login page
            }

            var model = new AdminPanelViewModel
            {
                Username = username,
                TotalBooks = BookRepository.Books.Count(b => !b.IsDeleted),
                TotalAuthors = AuthorRepository.Authors.Count(a => !a.IsDeleted),
                TotalGenres = GenreRepository.Genres.Count(),
            };

            return View(model); // Return the view with the model
        }
    }
}

