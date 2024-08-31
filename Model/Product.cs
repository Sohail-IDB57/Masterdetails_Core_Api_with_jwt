using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Masterdetails_Core_Api.Model
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<OrderDetail> Details { get; set; }
    }
}
