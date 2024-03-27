using BLL;

namespace BLL_EF
{
    public class BasketService : IBasketService
    {
        public void AddProduct(int userId, int productId, int amount)
        {
            throw new NotImplementedException();
        }

        public void EditProductAmount(int userId, int productId, int amount)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BasketPositionDTO> GetBasketContents(int userId)
        {
            throw new NotImplementedException();
        }

        public void RemoveAllProducts(int userId)
        {
            throw new NotImplementedException();
        }

        public void RemoveProduct(int productId, int userId)
        {
            throw new NotImplementedException();
        }
    }
}
