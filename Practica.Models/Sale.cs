using System;
using System.Collections.Generic;
using System.Text;

namespace Practica.Models
{
    public class Sale
    {
        public int SalesID { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
