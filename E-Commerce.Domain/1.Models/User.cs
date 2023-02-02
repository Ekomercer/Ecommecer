using E_Commerce.Domain._1.Entites.Base;

namespace E_Commerce.Domain._1.Models
{
    public class User : BaseEntity
    {
        public string role { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string LastName { get; set; }
        public string password { get; set; }
        public float PhoneNumber { get; set; }
    }
}
