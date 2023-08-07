namespace Easyshop.Models
{
    using System.Collections.Generic;

    public class Cart
    {
        public int CartId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

        public List<CartItem> Items { get; set; }
        public decimal TotalPrice { get; set; }
    }
  
}
