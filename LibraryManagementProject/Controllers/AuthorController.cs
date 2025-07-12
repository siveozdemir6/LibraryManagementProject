using LibraryManagementProject.Models;
using LibraryManagementProject.Repositories;
using LibraryManagementProject.ViewModels.Author;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementProject.Controllers
{
    public class AuthorController : BaseController
    {

        // 1-) Action method to display the list of authors
        public IActionResult List()
        {
            var authors = AuthorRepository.Authors // Fetching the list of authors from the repository (in-memory)
                .Where(a => !a.IsDeleted) // Filter out deleted authors
                .OrderBy(a => a.LastName) // Order authors by last name for better readability
                .Select(a => new AuthorListViewModel // Create a new AuthorListViewModel instance for each author
                {
                    Id = a.Id,
                    FullName = a.FullName,
                    DateOfBirth = a.DateOfBirth

                })
                .ToList();

            return View(authors);
        }
        // 2-) Action method to display author details
        public IActionResult Details(int id)
        {
            var author = AuthorRepository.Authors
                .FirstOrDefault(a => a.Id == id && !a.IsDeleted);

            if (author == null)
                return NotFound();

            var viewModel = new AuthorDetailsViewModel
            {
                Id = author.Id,
                FullName = author.FullName,
                DateOfBirth = author.DateOfBirth,
                Biography = author.Biography
            };

            return View(viewModel);
        }
        // 3-) List all books written by a specific author
        public IActionResult BooksByAuthor(int id)
        {
            // Get the author (ignore if deleted)
            var author = AuthorRepository.Authors
                .FirstOrDefault(a => a.Id == id && !a.IsDeleted);

            if (author == null)
                return NotFound();

            // Get the books written by this author
            var books = BookRepository.Books
                .Where(b => b.AuthorId == id && !b.IsDeleted)
                .OrderBy(b => b.Title)
                .Select(b => new AuthorBookViewModel
                {
                    Id = b.Id,
                    Title = b.Title,
                    PublishDate = b.PublishDate,
                    IsAvailable = b.IsAvailable
                })
                .ToList();

            // ViewBag values for display
            ViewBag.AuthorId = id; // for "Back to author" link
            ViewBag.AuthorName = author.FullName; // for displaying the name

            return View(books);
        }

        // 4-) Display Author Creation Form (From Admin Panel)
        [HttpGet]
        public IActionResult Create()
        {
            // Returns an empty form for adding a new author from the admin panel
            return View("Create", new AuthorCreateViewModel());
        }

        // Handle author creation submission from admin panel
        [HttpPost]
        public IActionResult Create(AuthorCreateViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                // Return form with validation errors if input is invalid
                return View("Create", viewModel);
            }

            // Use the helper method to add the new author
            AddNewAuthor(viewModel);

            TempData["SuccessMessage"] = "Yeni yazar başarıyla eklendi.";

            // Redirect user to the Author List page after successful creation
            return RedirectToAction("List", "Author");
        }


        // Display Author Creation Form (From Book Creation Page)
        [HttpGet]
        public IActionResult CreateFromBook()
        {
            // Returns the same author form, but return book creation page after submission
            return View("Create", new AuthorCreateViewModel());
        }


        // Handle author creation submission from Book creation page
        [HttpPost]
        public IActionResult CreateFromBook(AuthorCreateViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", viewModel);
            }

            // Add author using the helper method
            AddNewAuthor(viewModel);


            TempData["SuccessMessage"] = "Yeni yazar başarıyla eklendi.";

            // Redirect to Book Create page after successful author creation
            return RedirectToAction("Create", "Book");
        }

        #region  Private Helper 

        // I wrote this method to avoid code duplication
        // It is shared between Create and CreateFromBook actions
        private void AddNewAuthor(AuthorCreateViewModel viewModel)
        {
            // Add 1 to the maximum Id of existing authors to generate a new unique Id(id =1 if there is no author on the list)
            var newId = AuthorRepository.Authors.Any()? AuthorRepository.Authors.Max(a => a.Id) + 1 : 1;


            // Create a new Author object based on submitted data
            var newAuthor = new Author
            {
                Id = newId,
                FirstName = viewModel.FirstName.Trim(),
                LastName = viewModel.LastName.Trim(),
                DateOfBirth = (DateTime)viewModel.DateOfBirth,
                Biography = viewModel.Biography?.Trim()
            };

            // Add the new author to the in-memory data list
            AuthorRepository.Authors.Add(newAuthor);
        }

        #endregion



        // 5-) Action method to edit an existing author
        [HttpGet]
        public IActionResult Edit(int id)
        {
            // Find the author by Id (ignore if deleted)
            var author = AuthorRepository.Authors
                .FirstOrDefault(a => a.Id == id && !a.IsDeleted);
            if (author == null)
                return NotFound();
            // Create the view model for editing
            var viewModel = new AuthorEditViewModel
            {
                Id = author.Id,
                FirstName = author.FirstName,
                LastName = author.LastName,
                DateOfBirth = author.DateOfBirth,
                Biography = author.Biography
            };
            return View(viewModel);
        }



        // Handle author edit submission
        [HttpPost]
        public IActionResult Edit(AuthorEditViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel); // Return the form with validation errors
            }
            // Find the existing author by Id (ignore if deleted)
            var author = AuthorRepository.Authors
                .FirstOrDefault(a => a.Id == viewModel.Id && !a.IsDeleted);
            if (author == null)
                return NotFound();
            // Update the author's properties
            author.FirstName = viewModel.FirstName.Trim();
            author.LastName = viewModel.LastName.Trim();
            author.DateOfBirth = viewModel.DateOfBirth;
            author.Biography = viewModel.Biography?.Trim();
            TempData["SuccessMessage"] = "Yazar başarıyla güncellendi.";
            // Redirect to the Author List page after successful edit
            return RedirectToAction("List");
        }
    

        // 6-) Action method to delete an author (soft delete)
        [HttpGet]
        public IActionResult Delete(int id)
        {
            // Find the author by Id 
            var author = AuthorRepository.Authors
                .FirstOrDefault(a => a.Id == id);
            if (author == null)
                return NotFound();
            // Mark the author as deleted
            author.IsDeleted = true;
            TempData["SuccessMessage"] = "Yazar başarıyla silindi.";
            // Redirect to the Author List page after successful deletion
            return RedirectToAction("List");
        }
    }
}




