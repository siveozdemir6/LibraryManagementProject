using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagementProject.ViewModels.BorrowRecord
{
    public class BorrowCreateViewModel
    {
        [Required(ErrorMessage = "Lütfen bir kitap seçiniz.")]
        public int SelectedBookId { get; set; }

        [Required(ErrorMessage = "İsim soyisim boş bırakılamaz.")]
        public string BorrowerName { get; set; }

        [Required(ErrorMessage = "İletişim numarası boş bırakılamaz.")]
        public string BorrowerPhone { get; set; }

        // This will be used to populate the dropdown in the view
        public List<SelectListItem> AvailableBooks { get; set; } = new();
    }
}
