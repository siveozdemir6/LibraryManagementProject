namespace LibraryManagementProject.ViewModels.Admin
{
    public class AdminPanelViewModel
    {
        public string Username { get; set; } // Property to hold the username of the logged-in admin
        public int TotalBooks { get; set; } // Property to hold the total number of books in the library
        public int TotalAuthors { get; set; } // Property to hold the total number of authors in the library
        public int TotalGenres { get; set; } // Property to hold the total number of genres in the library

    }
}
