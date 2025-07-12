using System.ComponentModel.DataAnnotations;

namespace LibraryManagementProject.ViewModels.LoginUser
{
    public class LoginFormViewModel
    {

        [Required(ErrorMessage = "Kullanıcı adı boş bırakılamaz.")]
        public string Username { get; set; } // Username for login

        [Required(ErrorMessage = "Şifre boş bırakılamaz.")]
        [DataType(DataType.Password)]
        public string Password { get; set; } // Password for login
    }
}
