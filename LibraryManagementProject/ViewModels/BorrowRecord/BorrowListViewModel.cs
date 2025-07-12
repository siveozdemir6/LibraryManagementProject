namespace LibraryManagementProject.ViewModels.BorrowRecord
{
    public class BorrowListViewModel
    {
        public int Id { get; set; } // Unique identifier for the borrow record

        public string BookTitle { get; set; } // Title of the book being borrowed

        public string BorrowerName { get; set; } // Name of the person borrowing the book

        public string BorrowerPhone { get; set; } // Phone number of the borrower

        public DateTime BorrowedDate { get; set; } // Date when the book was borrowed

    }
}
