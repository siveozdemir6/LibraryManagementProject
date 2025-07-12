namespace LibraryManagementProject.ViewModels.Book
{
    public class BookListByGenreViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string AuthorFullName { get; set; } 

        public string LibrarySection { get; set; } 
        public DateTime PublishDate { get; set; } 
    }
}
