namespace LibraryManagementProject.Models
{
    public class Book : BaseClass
    {
        public string Title { get; set; } // Title of the book
        public int AuthorId { get; set; } // ID of the author
        public string ISBN { get; set; } // International Standard Book Number
        public DateTime PublishDate { get; set; } // Date when the book was published
        public int GenreId { get; set; } // ID of the genre the book belongs to
        public int PageCount { get; set; } // Number of pages in the book

        public string Description { get; set; } // Description of the book

        public int TotalCopies { get; set; } // Total number of copies of the book in the library

        public int BorrowedCopies { get; set; } // Number of copies currently borrowed by users

        public int CopiesAvailable => TotalCopies - BorrowedCopies;  // Number of copies available in the library

        public bool IsAvailable => CopiesAvailable > 0; // Property to check if the book is available for borrowing
    }
}