namespace LibraryManagementProject.ViewModels.Book
{
    public class BookDetailsViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string AuthorFullName { get; set; }
        public string GenreName { get; set; }
        public DateTime PublishDate { get; set; }
        public string ISBN { get; set; }
        public int CopiesAvailable { get; set; }
        public int PageCount { get; set; }
        public string LibrarySection { get; set; }
        public string Description { get; set; }
        public bool IsAvailable { get; set; }
    }
}
