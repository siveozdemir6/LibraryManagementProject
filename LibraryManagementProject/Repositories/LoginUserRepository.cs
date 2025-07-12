using LibraryManagementProject.Models;

namespace LibraryManagementProject.Repositories
{
    public class LoginUserRepository
    {
        public static List<LoginUser> Users = new List<LoginUser>
        {
            new LoginUser
            {
                Id = 1,
                Username = "siveozdemir",
                Password = "123456"
            },
            new LoginUser
            {
                Id = 2,
                Username = "sertanbozkus",
                Password = "123456"
            }
        };
    }
}
