using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Domain._1.Models
{
    public class Requests 
    {
        public DateTime Purchasedate { get; set; }
        public virtual Users Users { get; set; }
    }
}
