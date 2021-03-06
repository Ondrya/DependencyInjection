namespace DependencyInjection
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public Product Item { get; set; }
        public int Quantity { get; set; }
    }
}