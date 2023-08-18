using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWorkONWPF.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int ClientId { get; set; } 
        public int ProductId { get; set; } 
        public uint Quantity { get; set; }
        public DateTime ArriveTime { get; set; }

        public virtual Client Client { get; set; } 
        public virtual Product Product { get; set; } 
    }

}
