using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace Warehouse.Classes
{
    [Table(Name = "Warehouse_Users")]
    class User
    {
        [Column(Name = "id", IsPrimaryKey = true, IsDbGenerated = true)]
        public int id { get; set; }
        [Column(Name = "fio")]
        public string fio { get; set; }
        [Column(Name = "login")]
        public string login { get; set; }
        [Column(Name = "pass")]
        public string pass { get; set; }
        [Column(Name = "admin")]
        public int admin { get; set; }
    }
}
