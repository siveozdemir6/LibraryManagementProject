namespace LibraryManagementProject.ViewModels.Book
{
    public class BookListViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string AuthorFullName { get; set; } 

        public string GenreName { get; set; }
        public DateTime PublishDate { get; set; }

        public string LibrarySection { get; set; } // Represents the section of the library where this book is located
        public int CopiesAvailable { get; set; } // Number of copies currently available in the library
        public bool IsAvailable { get; set; }
    }
}
