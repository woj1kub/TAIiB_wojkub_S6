namespace BLL
{
    public interface IProductService
    {
        IEnumerable<ProductDTO> GetProducts();
        void AddProduct(ProductDTO product);
        void DeleteProduct(int productId);
        void EditProduct(ProductDTO product);
        void ActivateProduct(ProductDTO product);
    }
}
