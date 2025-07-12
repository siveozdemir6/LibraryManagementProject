using LibraryManagementProject.Models;
using LibraryManagementProject.Repositories;
using LibraryManagementProject.ViewModels.BorrowRecord;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LibraryManagementProject.Controllers
{
    public class BorrowController : BaseController
    {
        //Display borrow form 
        [HttpGet]
        public IActionResult Create()
        {
            var viewModel = new BorrowCreateViewModel();
            {
                viewModel.AvailableBooks = BookRepository.Books
                    .Where(b => b.IsAvailable && !b.IsDeleted) // Filter available books that are not deleted
                    .Select(b => new SelectListItem
                    {
                        Value = b.Id.ToString(), // Set the value to the book ID
                        Text = b.Title // Set the text to the book title
                    })
                    .ToList();
                    };
            return View(viewModel); // Return the view with the view model containing available books



        }

        //Process borrow form submission
        [HttpPost]
        public IActionResult Create(BorrowCreateViewModel viewModel)
        {
            var book = BookRepository.Books.FirstOrDefault(b => b.Id == viewModel.SelectedBookId && !b.IsDeleted); // Find the selected book by ID and ensure it is not deleted

            // Check if the book exists and is available for borrowing
            if (book == null || !book.IsAvailable) 
            {
                TempData["ErrorMessage"] = "Bu kitap şu anda ödünç vermek için uygun değil.";

                // Repopulate the available books in the view model
                viewModel.AvailableBooks = BookRepository.Books
                    .Where(b => !b.IsDeleted && b.IsAvailable)
                    .Select(b => new SelectListItem
                    {
                        Value = b.Id.ToString(),
                        Text = b.Title
                    })
                    .ToList();

                return View(viewModel);
            }

            var newRecord = new BorrowRecord // Create a new borrow record with the provided details
            {
                Id = BorrowRecordRepository.BorrowRecords.Any() ?
                     BorrowRecordRepository.BorrowRecords.Max(r => r.Id) + 1 : 1, // // Generate a new ID for the borrow record

                BookId = book.Id,
                BookTitle = book.Title,
                BorrowerName = viewModel.BorrowerName,
                BorrowerPhone = viewModel.BorrowerPhone,
                BorrowedDate = DateTime.Now
            };

            // Add the new borrow record to the repository and update the book's borrowed copies count
            BorrowRecordRepository.BorrowRecords.Add(newRecord);
            book.BorrowedCopies++;

            TempData["SuccessMessage"] = $"'{book.Title}' başarıyla ödünç verildi!";
            return RedirectToAction("List");
        }

        // Display the list of borrow records
        public IActionResult List()
        {
            var activeBorrowedRecords = BorrowRecordRepository.BorrowRecords
                .Where(r => r.ReturnDate == null)
                .Select(r=> new BorrowListViewModel
                {
                    Id = r.Id,
                    BookTitle = r.BookTitle,
                    BorrowerName = r.BorrowerName,
                    BorrowerPhone = r.BorrowerPhone,
                    BorrowedDate = r.BorrowedDate,
                })
                .ToList();

            return View(activeBorrowedRecords); // Pass the list of active borrow records to the view

        }

        //Return a borrowed book

        [HttpGet]

        public IActionResult Return(int id)
        {
            var record = BorrowRecordRepository.BorrowRecords.FirstOrDefault(r => r.Id == id ); // Find the borrow record by ID
            if (record == null && record.ReturnDate != null)
            {
                TempData["ErrorMessage"] = "Bu ödünç kayıt bulunamadı veya zaten iade edildi.";
                return RedirectToAction("List");
            }
            // Mark the book as returned
            record.ReturnDate = DateTime.Now;
            // Find the corresponding book and update its borrowed copies count
            var book = BookRepository.Books.FirstOrDefault(b => b.Id == record.BookId);
            if (book != null)
            {
                book.BorrowedCopies--;
            }
            record.ReturnDate = DateTime.Now; // Set the return date to the current date
            TempData["SuccessMessage"] = $"'{record.BookTitle}' başarıyla iade edildi!";
            return RedirectToAction("List");
        }


    }

}

