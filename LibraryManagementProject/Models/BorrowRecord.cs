namespace LibraryManagementProject.Models
{
    public class BorrowRecord
    {
        public int Id { get; set; } // Unique identifier for the borrow record

        public int BookId { get; set; } // ID of the book being borrowed

        public string BookTitle { get; set; } // Title of the book being borrowed

        public string BorrowerName { get; set; } // Name of the person borrowing the book

        public string BorrowerPhone { get; set; } // Phone number of the borrower

        public DateTime BorrowedDate { get; set; } // Date when the book was borrowed

        public DateTime? ReturnDate { get; set; } // Date when the book was returned, nullable if not yet returned
    }
}
