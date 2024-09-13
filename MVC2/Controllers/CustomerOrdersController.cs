using Microsoft.AspNetCore.Mvc;
using MVC2.Models;

namespace MVC2.Controllers;

public class CustomerOrdersController : Controller
{
    // GET
    public IActionResult Index()
    {
        var customer2 = new Customer
        {
            Id = 1,
            FirstName = "Penelope",
            LastName = "Doe",
            Email = "penn.doe@example.com"
        };
        
        // Sipariş nesneleri oluştur
        var order1 = new Order
        {
            Id = 1001,
            ProductName = "Tütün Kolonyası",
            Price = new decimal(125.45343),
            Quantity = 3
        };

        var order2 = new Order
        {
            Id = 1002,
            ProductName = "Boks Eldiveni",
            Price = new decimal(15.4508943),
            Quantity = 4
        };

        var order3 = new Order
        {
            Id = 1003,
            ProductName = "Boks Eldiveni",
            Price = new decimal(15.42533),
            Quantity = 4
        };
        List<Order> orders = new List<Order>();
        orders.Add(order1);
        orders.Add(order2);
        orders.Add(order3);

        var viewModel = new CustomerOrderViewModel
        {
            Customer = customer2,
            Orders = orders
            
        };
       

        return View(viewModel);
    }
}