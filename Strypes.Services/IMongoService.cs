using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Strypes.Services
{
    [ServiceContract]
    public interface IMongoService
    {
        [OperationContract]
        List<Category> GetCategories();

        [OperationContract]
        List<Product> GetProducts();

        [OperationContract]
        List<Product> GetProductsBy(string searchField, string searchString);

        [OperationContract]
        string InsertCategory(Category category);

        [OperationContract]
        void DeleteCategory(string categoryId);

        [OperationContract]
        void UpdateCategory(Category category);


        [OperationContract]
        List<Product> GetProductsByCategory(string category);

        [OperationContract]
        string InsertProduct(Product product);

        [OperationContract]
        void DeleteProduct(string productId);

        [OperationContract]
        void UpdateProduct(Product product);
    }
}
