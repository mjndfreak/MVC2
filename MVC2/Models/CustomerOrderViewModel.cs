using System.Collections;

namespace MVC2.Models;

public class CustomerOrderViewModel
{
    public Customer Customer { get; set; }
    public List<Order> Orders { get; set; }
    
}