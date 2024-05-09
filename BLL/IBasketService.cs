namespace BLL
{
    public interface IBasketService
    {
        void AddProduct(int userId, int productId, int amount);
        void RemoveProduct(int productId, int userId);
        void RemoveAllProducts(int userId);
        void EditProductAmount(int userId, int productId, int amount);
        IEnumerable<BasketPositionDTO> GetBasketContents(int userId);
    }
}
