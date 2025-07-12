using System.ComponentModel.DataAnnotations;

namespace LibraryManagementProject.ViewModels.Book
{
    public class BookEditViewModel
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Kitap adı boş bırakılamaz.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Yazar boş bırakılamaz.")]
        public int? AuthorId { get; set; }

        [Required(ErrorMessage = "Tür boş bırakılamaz.")]
        public int? GenreId { get; set; }

        [Required(ErrorMessage = "Yayın tarihi boş bırakılamaz.")]
        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; }

        [Required(ErrorMessage = "ISBN boş bırakılamaz.")]
        public string ISBN { get; set; }

        [Required(ErrorMessage = "Sayfa sayısı boş bırakılamaz.")]
        [Range(1, int.MaxValue, ErrorMessage = "Sayfa sayısı en az 1 olmalıdır.")]
        public int PageCount { get; set; }

        [Required(ErrorMessage = "Açıklama boş bırakılamaz.")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Toplam kopya sayısı boş bırakılamaz.")]
        [Range(0, int.MaxValue, ErrorMessage = "Kopya sayısı  en az 0 olmalıdır.")]
        public int TotalCopies { get; set; }
    }
}
