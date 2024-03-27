namespace BLL
{
    public interface IOrderService
    {
        void CreateOrder(int userId);
        IEnumerable<OrderDTO> GetAllOrders();
        IEnumerable<OrderDTO> GetUserOrders(int userId);
        IEnumerable<OrderPositionDTO> GetOrderPositions(int orderId);
    }
}
