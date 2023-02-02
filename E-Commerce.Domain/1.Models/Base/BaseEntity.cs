namespace E_Commerce.Domain._1.Entites.Base
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CreatBy { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? LastUpdatedBy { get; set; }
        public DateTime LastUpdatedOn { get; set;}
    }
}
