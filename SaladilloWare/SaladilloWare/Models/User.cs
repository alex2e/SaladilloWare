using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace SaladilloWare.Models
{
    [Table("user")]
    public class User
    {
        [PrimaryKey, MaxLength(4)]
        public String CodUser { get; set; }
        [MaxLength(10), NotNull]
        public String Password { get; set; }
        [MaxLength(50), NotNull]
        public String Name { get; set; }
        [MaxLength(7), NotNull]
        public String Type { get; set; }
    }
}
