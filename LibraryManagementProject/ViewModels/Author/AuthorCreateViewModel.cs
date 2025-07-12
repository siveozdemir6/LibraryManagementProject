using System.ComponentModel.DataAnnotations;

namespace LibraryManagementProject.ViewModels.Author
{
    public class AuthorCreateViewModel
    {
        [Required(ErrorMessage = "Yazarın adı zorunludur.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Yazarın soyadı zorunludur.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Doğum tarihi zorunludur.")]
        public DateTime? DateOfBirth { get; set; }

        public string? Biography { get; set; }
    }
}
