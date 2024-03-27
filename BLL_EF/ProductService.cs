using BLL;

namespace BLL_EF
{
    public class ProductService : IProductService
    {
        private List<ProductDTO> products = new List<ProductDTO>();
        public void ActivateProduct(ProductDTO product)
        {
            if (product == null) throw new ArgumentNullException("Nie podano produktu");
            if (product.IsActive) throw new ArgumentException("Produkt już jest aktywny");
            product.IsActive = true;
        }

        public void AddProduct(ProductDTO product)
        {
            if (product == null) throw new ArgumentNullException("Nie podano produktu");
            if (product.Price < 0) throw new ArgumentException($"Cena produktu: {product.Price} nie może być < 0");
            products.Add(product);
        }

        public void DeleteProduct(int productId)
        {
            throw new NotImplementedException();
        }

        public void EditProduct(ProductDTO product)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductDTO> GetProducts()
        {
            throw new NotImplementedException();
        }
    }
}
