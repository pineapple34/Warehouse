using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace Warehouse.Classes
{
    [Table(Name = "Warehouse_OrdersView")]
    class OrdersView
    {
        [Column(Name = "id", IsPrimaryKey = true, IsDbGenerated = true)]
        public int id { get; set; }
        [Column(Name = "fio")]
        public string fio { get; set; }
        [Column(Name = "product")]
        public string product { get; set; }
        [Column(Name = "quantity")]
        public int quantity { get; set; }
        [Column(Name = "date")]
        public string date { get; set; }
        [Column(Name = "cost")]
        public double cost { get; set; }
    }
}
