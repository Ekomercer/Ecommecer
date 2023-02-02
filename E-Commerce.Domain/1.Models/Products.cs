using E_Commerce.Domain._1.Entites.Base;

namespace E_Commerce.Domain._1.Models
{
    public class Products : BaseEntity
    {
        public int Id { get; set; }
        public int price { get; set; }
        public string Img { get; set; }
        public string Description { get; set; }

        public virtual Stock Stock { get; set; }
        public virtual Category Category { get; set; }
    }
}
