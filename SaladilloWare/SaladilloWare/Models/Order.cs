using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaladilloWare.Models
{
    [Table("Order")]
    public class Order
    {
        [PrimaryKey, AutoIncrement]
        public int CodOrder { get; set; }
        [MaxLength(50), NotNull]
        public String NameClient { get; set; }
        [NotNull]
        public int CodPlaca { get; set; }
        [NotNull]
        public int CodProcesador { get; set; }
        [NotNull]
        public int CodTorre { get; set; }
        [NotNull]
        public int CodMemoria { get; set; }
        [NotNull]
        public int CodGrafica { get; set; }
        [NotNull]
        public double PrecioTotal { get; set; }
    }
}
