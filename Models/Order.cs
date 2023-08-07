namespace Easyshop.Models
{
    using System;

    public class Order
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
        public string Status { get; set; }

        public List<OrderItem> Items { get; set; }
    }

}
