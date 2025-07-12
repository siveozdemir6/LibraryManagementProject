using LibraryManagementProject.Repositories;
using LibraryManagementProject.ViewModels.Map;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementProject.Controllers
{
    public class MapController : BaseController
    {
        public IActionResult LibraryMap()
        {
            var genres = GenreRepository.Genres;
            var viewModel = new LibraryMapViewModel
            {
                Genres = genres
            };
            return View(viewModel);
        }
    }
}
