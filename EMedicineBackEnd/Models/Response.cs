namespace EMedicineBackEnd.Models
{
    public class Response
    {
        public int StatusCode { get; set; }

        public string StatusMessage { get; set; }

        public List<User> listUsers { get; set; }
        
        public User user { get; set; }
       
        public List<Medicine> listMedicines { get; set; }
       
        public Medicine Medicine { get; set; }
        
        public List<Chart> listChart { get; set; }

        public List<Order> listOrders { get; set; }

        public Order order { get; set; }

        public List<OrderItem> listOrderItem { get; set; }

        public OrderItem orderItem { get; set; }



    }
}
