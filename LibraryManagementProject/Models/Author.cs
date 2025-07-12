namespace LibraryManagementProject.Models
{
    public class Author : BaseClass 
    {
        public string FirstName { get; set; } // First name of the author

        public string LastName { get; set; } // Last name of the author

        public string Biography { get; set; } // Biography of the author

        public DateTime DateOfBirth { get; set; } // Date of birth of the author

        public string FullName => $"{FirstName} {LastName}"; // Full name of the author, combining first and last names
    }
}
