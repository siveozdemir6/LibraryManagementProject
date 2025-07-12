using System.ComponentModel.DataAnnotations;

namespace LibraryManagementProject.ViewModels.Genre
{
    public class GenreEditViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Tür adı boş bırakılamaz.")]
        [StringLength(100, ErrorMessage = "Tür adı en fazla 100 karakter olabilir.")]
        public string GenreName { get; set; }

        [StringLength(100, ErrorMessage = "Kütüphane bölümü en fazla 100 karakter olabilir.")]
        public string LibrarySection { get; set; }
    }
}
