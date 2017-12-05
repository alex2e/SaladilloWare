using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaladilloWare.Models
{
    [Table("Product")]
    public class Product
    {
        [PrimaryKey]
        public int CodProd { get; set; }
        [MaxLength(50), NotNull]
        public String Name { get; set; }
        [NotNull]
        public double Precio { get; set; }
        [MaxLength(20), NotNull]
        public String Type { get; set; }
    }
}
