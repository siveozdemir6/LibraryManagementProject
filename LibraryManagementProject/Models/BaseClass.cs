namespace LibraryManagementProject.Models
{
    public class BaseClass
    {
        public int Id { get; set; } // Unique identifier for the entity

        public bool IsDeleted { get; set; } // Flag to indicate if the entity is deleted or not
    }
}
