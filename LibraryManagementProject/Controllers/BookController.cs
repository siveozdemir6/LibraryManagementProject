using LibraryManagementProject.Models;
using LibraryManagementProject.Repositories;
using LibraryManagementProject.ViewModels.Book;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LibraryManagementProject.Controllers
{
    public class BookController : BaseController
    {

        //1-)Action method to display the list of books
        public IActionResult List()
        {
            var books = BookRepository.Books; // Retrieve the list of books from the repository

            //Convert book objects to BookListViewModel and prepare the data for the view
            var bookListViewModel = books
                .Where(book => !book.IsDeleted) // Filter out deleted books
                .OrderBy(book => book.Title) // Order books by title
                .Select(book =>
                {
                    // Find the author and genre for each book using their IDs
                    var author = AuthorRepository.Authors
                        .Where(a => !a.IsDeleted)
                        .FirstOrDefault(a => a.Id == book.AuthorId);
                    var genre = GenreRepository.Genres
                        .Where(g => !g.IsDeleted)
                        .FirstOrDefault(g => g.Id == book.GenreId);

                    //Create a new BookListViewModel instance and populate it with book data
                    return new BookListViewModel
                    {
                        Id = book.Id,
                        Title = book.Title,
                        AuthorFullName = author?.FullName ?? "Yazar Bulunamadı",
                        GenreName = genre?.GenreName ?? "Tür bulunamadı", // Use null-conditional operator to avoid null reference exceptions
                        PublishDate = book.PublishDate,
                        LibrarySection =genre?.LibrarySection ?? "Kütüphane Bölüm Bilgisi Bulunamadı", 
                        CopiesAvailable = book.CopiesAvailable,
                        IsAvailable = book.IsAvailable 
                    };
                })
                .ToList(); // Convert the result to a list

            //Pass the list of BookListViewModel to the view
            return View(bookListViewModel);
        }
        //2) Details action method to display book details
        public IActionResult Details(int id, int? returnToAuthorId)
        {
            var book = BookRepository.Books // Retrieve the book by ID
                .Where(b => !b.IsDeleted)
                .FirstOrDefault(b => b.Id == id);

            if (book == null) // Check if the book exists
            {
                return NotFound();
            }

            var author = AuthorRepository.Authors
                .FirstOrDefault(a => !a.IsDeleted && a.Id == book.AuthorId);

            var genre = GenreRepository.Genres
                .FirstOrDefault(g => !g.IsDeleted && g.Id == book.GenreId);

            var viewModel = new BookDetailsViewModel
            {
                Id = book.Id,
                Title = book.Title,
                AuthorFullName = author?.FullName ?? "Yazar Bulunamadı",
                GenreName = genre?.GenreName ?? "Tür Bulunamadı",
                LibrarySection = genre?.LibrarySection ?? "Kütüphane Bölüm Bilgisi Bulunamadı",
                PublishDate = book.PublishDate,
                ISBN = book.ISBN,
                PageCount = book.PageCount,
                Description = book.Description,
                CopiesAvailable = book.CopiesAvailable,
                IsAvailable = book.IsAvailable
            };

            ViewBag.ReturnToAuthorId = returnToAuthorId;
            return View(viewModel);
        }


        // 3-) Action method to list books by genre
        public IActionResult BooksByGenre(int id)
        {
            // Get genre by ID and ensure it's not deleted
            var genre = GenreRepository.Genres.FirstOrDefault(g => g.Id == id && !g.IsDeleted);
            if (genre == null)
                return NotFound();

            // Fetch books with matching genre and that are not deleted
            var books = BookRepository.Books
                .Where(b => b.GenreId == id && !b.IsDeleted)
                .OrderBy(b => b.Title)
                .Select(book =>
                {
                    var author = AuthorRepository.Authors.FirstOrDefault(a => a.Id == book.AuthorId && !a.IsDeleted);

                    return new BookListByGenreViewModel
                    {
                        Id = book.Id,
                        Title = book.Title,
                        AuthorFullName = author?.FullName ?? "Yazar Bulunamadı",
                        PublishDate = book.PublishDate
                    };
                }).ToList();

            // Pass selected genre name and library section info to the view
            ViewBag.SelectedGenre = genre.GenreName;
            ViewBag.LibrarySection = genre.LibrarySection;

            return View("ListByGenre", books);
        }


        // 4-) Action method to create a new book

        [HttpGet]
        public IActionResult Create()
        {
            return View(new BookCreateViewModel());
        }

        [HttpPost]
        public IActionResult Create(BookCreateViewModel model)
        {
            if (!ModelState.IsValid) 
            {
                return View(model); 
            }

            var newBook = new Book
            {
                Id = BookRepository.Books.Any() ? BookRepository.Books.Max(b => b.Id) + 1 : 1,
                Title = model.Title.Trim(),
                AuthorId = model.AuthorId.Value,
                GenreId = model.GenreId.Value,
                PublishDate = (DateTime)model.PublishDate,
                ISBN = model.ISBN.Trim(),
                PageCount = model.PageCount,
                Description = model.Description?.Trim(),
                TotalCopies = model.TotalCopies,
                BorrowedCopies = 0, // Initialize borrowed copies to 0
                IsDeleted = false

            };

            BookRepository.Books.Add(newBook);

            TempData["SuccessMessage"] = "Yeni kitap başarıyla eklendi.";
            return RedirectToAction("List");
        }
        // 5-) Action method to edit an existing book
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var book = BookRepository.Books
                .FirstOrDefault(b => b.Id == id && !b.IsDeleted);

            if (book == null)
            {
                return NotFound();
            }

            var viewModel = new BookEditViewModel
            {
                Id = book.Id,
                Title = book.Title,
                AuthorId = book.AuthorId,
                GenreId = book.GenreId,
                PublishDate = book.PublishDate,
                ISBN = book.ISBN,
                PageCount = book.PageCount,
                Description = book.Description,
                TotalCopies = book.TotalCopies,
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Edit(BookEditViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model); // viewbags are already set in the base controller
            }

            var book = BookRepository.Books
                .FirstOrDefault(b => b.Id == model.Id && !b.IsDeleted);

            if (book == null)
            {
                return NotFound();
            }

            // Update book data
            book.Title = model.Title.Trim();
            book.AuthorId = model.AuthorId.Value;
            book.GenreId = model.GenreId.Value;
            book.PublishDate = model.PublishDate;
            book.ISBN = model.ISBN.Trim();
            book.PageCount = model.PageCount;
            book.Description = model.Description?.Trim();
            book.TotalCopies = model.TotalCopies;

            TempData["SuccessMessage"] = "Kitap başarıyla güncellendi.";
            return RedirectToAction("List");
        }

        // 6-) Action method to delete a book

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var book = BookRepository.Books.FirstOrDefault(b => b.Id == id);
            if (book == null)
            {
                return NotFound();
            }

            book.IsDeleted = true;
            TempData["SuccessMessage"] = "Kitap başarıyla silindi.";
            return RedirectToAction("List");
        }





    }
}

