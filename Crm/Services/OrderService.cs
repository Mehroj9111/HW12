using Crm.Entities;
namespace Crm.Services;

class OrderService
{
    private List<Order> orders = new List<Order>();

    public void CreateOrder(Order order)
    {
        orders.Add(order);
    }

    public Order GetOrderById(int orderId)
    {
        return orders.FirstOrDefault(o => o.OrderId == orderId);
    }

    public Order GetOrderByDescription(string description)
    {
        return orders.FirstOrDefault(o => o.Description == description);
    }
}

   