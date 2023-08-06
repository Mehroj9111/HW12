using Crm.Entities;
using Crm.Services;

class Program
{
    static void Main(string[] args)
    {
        OrderService orderService = new OrderService();
        ClientService clientService = new ClientService();

        Order order1 = new Order(1, "Order 1");
        Order order2 = new Order(2, "Order 2");
        Order order3 = new Order(3, "Order 3");

        Client client1 = new Client("John", "Doe");
        Client client2 = new Client("Jane", "Smith");
        Client client3 = new Client("Mike", "Johnson");

        orderService.CreateOrder(order1);
        orderService.CreateOrder(order2);
        orderService.CreateOrder(order3);

        clientService.CreateClient(client1);
        clientService.CreateClient(client2);
        clientService.CreateClient(client3);

        Order orderById = orderService.GetOrderById(2);
        Console.WriteLine($"Order by Id: {orderById?.Description}");

        Order orderByDescription = orderService.GetOrderByDescription("Order 3");
        Console.WriteLine($"Order by Description: {orderByDescription?.OrderId}");

        Client clientByName = clientService.GetClientByName("Jane", "Smith");
        Console.WriteLine($"Client by Name: {clientByName?.FirstName} {clientByName?.LastName}");
    }
}