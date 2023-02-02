using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Domain._1.Models
{
    public class Itens
    {
        public int Id { get; set; }
        public int amount { get; set; }
        public virtual Products Products { get; set; }
        public virtual Requests Requests { get; set; }

    }
}
