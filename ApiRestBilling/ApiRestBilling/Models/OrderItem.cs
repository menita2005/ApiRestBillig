using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Http.Headers;

namespace ApiRestBilling.Models
{
    public class OrderItem
    {
        [Key]
            public int Id { get; set; }
            public int OrderId { get; set; }
        public int ProductoId { get; set; }
        public decimal UnitPrice { get; set; } = 0;
        public int Quantity { get; set; } = 1;
        [ForeignKey("OrderId")]
        public virtual Order Order { get; set; }
        [ForeignKey("ProductoId")]
        public virtual Product Product { get; set; }

    }
}
