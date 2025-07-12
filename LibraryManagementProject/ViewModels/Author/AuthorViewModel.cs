﻿namespace LibraryManagementProject.ViewModels.Author
{
    public class AuthorViewModel
    {
        public int? Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Biography { get; set; }
    }
}
