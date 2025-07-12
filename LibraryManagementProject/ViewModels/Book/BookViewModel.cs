namespace LibraryManagementProject.ViewModels.Book
{
    public class BookViewModel
    {
        public int? Id { get; set; }

        public string Title { get; set; }

        public int AuthorId { get; set; }

        public int GenreId { get; set; }

        public DateTime PublishDate { get; set; }

        public string ISBN { get; set; }

        public int CopiesAvailable { get; set; }

        public int PageCount { get; set; }

        public string Description { get; set; }
    }
}
