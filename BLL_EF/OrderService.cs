using BLL;

namespace BLL_EF
{
    public class OrderService : IOrderService
    {
        public void CreateOrder(int userId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderDTO> GetAllOrders()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderPositionDTO> GetOrderPositions(int orderId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderDTO> GetUserOrders(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
