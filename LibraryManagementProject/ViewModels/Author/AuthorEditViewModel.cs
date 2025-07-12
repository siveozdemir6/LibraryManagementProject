using System.ComponentModel.DataAnnotations;

namespace LibraryManagementProject.ViewModels.Author
{
    public class AuthorEditViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ad alanı zorunludur.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Soyad alanı zorunludur.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Doğum tarihi zorunludur.")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        public string? Biography { get; set; }
    }
}
