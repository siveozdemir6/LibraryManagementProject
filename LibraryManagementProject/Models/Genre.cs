namespace LibraryManagementProject.Models
{
    public class Genre : BaseClass
    {
        public string GenreName { get; set; }

        public string LibrarySection { get; set; } // Represents the section of the library where this genre is located
    }
}
