using System;
using LibraryManagementProject.Models;
using LibraryManagementProject.Repositories;
using LibraryManagementProject.ViewModels.Genre;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementProject.Controllers
{
    public class GenreController : BaseController
    {
        // 1-) Action method to display the list of genres
        public IActionResult List()
        {
            var genres = GenreRepository.Genres // Fetching the list of genres from the repository (in-memory)
                .Where(g => !g.IsDeleted) // Filter out deleted genres
                .OrderBy(g => g.GenreName) // Order genres by name for better readability
                .Select(g => new GenreListViewModel
                {
                    Id = g.Id,
                    GenreName = g.GenreName,
                    LibrarySection = g.LibrarySection,
                })
                .ToList();
            return View(genres); // Pass the list of genre view models to the view
        }

        // 2-) Action method to add a new genre

        // Show genre creation form (from admin panel)
        [HttpGet]
        public IActionResult Create()
        {
            return View("Create", new GenreCreateViewModel());
        }

        // Handle genre creation form submission (from admin panel)
        [HttpPost]
        public IActionResult Create(GenreCreateViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return View("Create", viewModel);

            AddNewGenre(viewModel);
            TempData["SuccessMessage"] = "Yeni tür başarıyla eklendi.";
            return RedirectToAction("List", "Genre");
        }

        // show genre creation form (from Book/Create page)
        [HttpGet]
        public IActionResult CreateFromBook()
        {
            return View("Create", new GenreCreateViewModel());
        }

        // Handle genre creation form submission (from Book/Create page)
        [HttpPost]
        public IActionResult CreateFromBook(GenreCreateViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return View("Create", viewModel);

            AddNewGenre(viewModel);
            TempData["SuccessMessage"] = "Yeni tür başarıyla eklendi.";
            return RedirectToAction("Create", "Book"); // Kitap ekleme sayfasına geri dön
        }

        #region 

        // Shared method to avoid code duplication between Create & CreateFromBook
        private void AddNewGenre(GenreCreateViewModel viewModel)
        {
            var newGenre = new Genre
            {
                Id = GenreRepository.Genres.Max(g => g.Id) + 1,
                GenreName = viewModel.GenreName.Trim(),
                LibrarySection = viewModel.LibrarySection?.Trim()
            };

            GenreRepository.Genres.Add(newGenre);
        }

        #endregion

        // 3-) Action method to edit an existing genre
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var genre = GenreRepository.Genres
                .FirstOrDefault(g => g.Id == id && !g.IsDeleted);

            if (genre == null)
                return NotFound();

            var viewModel = new GenreEditViewModel
            {
                Id = genre.Id,
                GenreName = genre.GenreName,
                LibrarySection = genre.LibrarySection
            };

            return View(viewModel);
        }

        // Handles form submission for editing a genre
        [HttpPost]
        public IActionResult Edit(GenreEditViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            var genre = GenreRepository.Genres
                .FirstOrDefault(g => g.Id == viewModel.Id && !g.IsDeleted);

            if (genre == null)
                return NotFound();

            // Update genre fields
            genre.GenreName = viewModel.GenreName.Trim();
            genre.LibrarySection = viewModel.LibrarySection?.Trim();

            TempData["SuccessMessage"] = "Tür başarıyla güncellendi.";
            return RedirectToAction("List");
        }

        // 4-) Action method to delete a genre
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var genre = GenreRepository.Genres
                .FirstOrDefault(g => g.Id == id && !g.IsDeleted);
            if (genre == null)
                return NotFound();
            // Soft delete the genre by marking it as deleted
            genre.IsDeleted = true;
            TempData["SuccessMessage"] = "Tür başarıyla silindi.";
            return RedirectToAction("List");

        }
    }
}




