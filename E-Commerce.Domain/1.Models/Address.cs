namespace E_Commerce.Domain._1.Models
{
    public class Address
    {
        public string Cep { get; set; }
        public string City { get; set; }
        public string StreetName { get; set; }
        public string complement { get; set; }

        public virtual Users Users { get; set; }
    }
}
