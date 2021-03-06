using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace Warehouse.Classes
{
    [Table(Name = "Warehouse_Clients")]
    class Client
    {
        [Column(Name = "id", IsPrimaryKey = true, IsDbGenerated = true)]
        public int id { get; set; }
        [Column(Name = "fio")]
        public string fio { get; set; }
        [Column(Name = "address")]
        public string address { get; set; }
        [Column(Name = "number")]
        public string number { get; set; }
        [Column(Name = "status")]
        public int status { get; set; }
    }
}
