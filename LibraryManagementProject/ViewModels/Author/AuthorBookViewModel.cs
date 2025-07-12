namespace LibraryManagementProject.ViewModels.Author
{
    public class AuthorBookViewModel
    {
        public int Id { get; set; } // Unique identifier for the book

        public string Title { get; set; } // Title of the book

        public DateTime PublishDate { get; set; } // Date when the book was published

        public bool IsAvailable { get; set; } // Indicates if the book is available for borrowing
    }
}
