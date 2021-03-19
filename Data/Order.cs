using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ODataOrders.Data
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string Product { get; set; }
        public int Quantity { get; set; }
        public int Revenue { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
    }
}
