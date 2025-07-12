using System.ComponentModel.DataAnnotations;

namespace LibraryManagementProject.ViewModels.Genre
{
    public class GenreCreateViewModel
    {
        [Required(ErrorMessage = "Tür adı boş bırakılamaz.")]
        [StringLength(50, ErrorMessage = "Tür adı en fazla 50 karakter olabilir.")]
        public string GenreName { get; set; }

        [Required(ErrorMessage = "Kütüphane bölümü boş bırakılamaz.")]
        [StringLength(50, ErrorMessage = "Kütüphane bölümü en fazla 50 karakter olabilir.")]
        public string LibrarySection { get; set; }

    }
}
