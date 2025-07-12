using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Rendering;
using LibraryManagementProject.Repositories;
using System.IO;

public class BaseController : Controller
{
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        // ViewBags: For dropdown and navbar
        ViewBag.Authors = AuthorRepository.Authors
            .Where(a => !a.IsDeleted)
            .OrderBy(a => a.LastName)
            .Select(a => new SelectListItem
            {
                Value = a.Id.ToString(),
                Text = a.FullName
            }).ToList();

        ViewBag.GenresSelectList = GenreRepository.Genres
            .Where(g => !g.IsDeleted)
            .OrderBy(g => g.GenreName)
            .Select(g => new SelectListItem
            {
                Value = g.Id.ToString(),
                Text = g.GenreName
            }).ToList();

        ViewBag.Genres = GenreRepository.Genres
            .Where(g => !g.IsDeleted)
            .OrderBy(g => g.GenreName)
            .ToList();

        // Login control
        var username = context.HttpContext.Session.GetString("Username");
        var path = context.HttpContext.Request.Path.Value?.ToLower();

        // If someone tries to go to these pages without login 
        var protectedPaths = new[]
        {
            "/book/create",
            "/book/edit",
            "/book/delete",
            "/author/create",
            "/author/edit",
            "/author/delete",
            "/genre/create",
            "/genre/edit",
            "/genre/delete",
            "/borrow/create",
            "/borrow/list",
            "/borrow/return",
            "/admin"
        };

        if (string.IsNullOrEmpty(username) && path != null && protectedPaths.Contains(path))
        {
            context.Result = new RedirectToActionResult("Login", "LoginUser", null);
            return;
        }

        base.OnActionExecuting(context);
    }
}



