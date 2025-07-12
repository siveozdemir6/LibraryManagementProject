namespace LibraryManagementProject.ViewModels.Genre
{
    public class GenreListViewModel
    {
        public int Id { get; set; }
        public string GenreName { get; set; }
        public string LibrarySection { get; set; } // Represents the section of the library where this genre is located

    }
}
