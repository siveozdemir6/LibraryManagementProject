using LibraryManagementProject.Models;

namespace LibraryManagementProject.Repositories
{
    public class BorrowRecordRepository
    {
        public static List<BorrowRecord> BorrowRecords { get; set; } = new List<BorrowRecord>();
    }
}
