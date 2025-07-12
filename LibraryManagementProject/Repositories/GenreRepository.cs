using LibraryManagementProject.Models;

namespace LibraryManagementProject.Repositories
{
    public class GenreRepository
    {
        public static List<Genre> Genres = new List<Genre>
        {
            new Genre { Id = 1, GenreName = "Dünya Klasikleri", LibrarySection ="1. Kat 1A Rafı" },
            new Genre { Id = 2, GenreName = "Bilim Kurgu", LibrarySection = "1. Kat 1B Rafı" },
            new Genre { Id = 3, GenreName = "Fantastik", LibrarySection = "1. Kat 1C Rafı" },
            new Genre { Id = 4, GenreName = "Korku-Gerilim", LibrarySection = "1. Kat 2A Rafı" },
            new Genre { Id = 5, GenreName = "Türk Klasikleri", LibrarySection = "1. Kat 2B Rafı" },
            new Genre { Id = 6, GenreName = "Roman", LibrarySection = "1. Kat 2C Rafı" },
            new Genre { Id = 7, GenreName = "Şiir", LibrarySection = "2. Kat 3A Rafı" },
            new Genre { Id = 8, GenreName = "Macera-Aksiyon", LibrarySection = "2. Kat 3B Rafı"  },
            new Genre { Id = 9, GenreName = "Polisiye", LibrarySection = "2. Kat 3C Rafı" },
            new Genre { Id = 10, GenreName = "Psikoloji", LibrarySection = "2. Kat 4A Rafı" },
            new Genre { Id = 11, GenreName = "Felsefe", LibrarySection = "2. Kat 4B Rafı" },
            new Genre { Id = 12, GenreName = "Tarih", LibrarySection = "1. Kat 5A Rafı" },
            new Genre { Id = 13, GenreName = "Ekonomi", LibrarySection = "1. Kat 5B Rafı" },
            new Genre { Id = 14, GenreName = "Siyaset", LibrarySection = "1. Kat 5C Rafı" },
            new Genre { Id = 15, GenreName = "Sosyoloji", LibrarySection = "1. Kat 7A Rafı" },
            new Genre { Id = 16, GenreName = "Biyografi", LibrarySection = "1. Kat 7B Rafı" },
            new Genre { Id = 12, GenreName = "Tiyatro", LibrarySection = "1. Kat 7C Rafı" },
        };
    }
}
