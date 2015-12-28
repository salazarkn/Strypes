using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Linq;
using MongoDB.Driver.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Strypes.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MongoService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select MongoService.svc or MongoService.svc.cs at the Solution Explorer and start debugging.
    public class MongoService : IMongoService
    {
        private static MongoClient client = new MongoClient(new MongoUrl("mongodb://localhost"));
        private static MongoServer server = client.GetServer();
        private static MongoDatabase dbServer = server.GetDatabase("strypes_Yasen_Raykov_db");

        public List<Category> GetCategories()
        {
            List<Category> result = dbServer.GetCollection<Category>("categories").FindAll().ToList<Category>();
            return result;
        }

        public List<Product> GetProductsBy(string searchField, string searchString)
        {
            MongoCursor<Product> result;
            MongoCollection<Product> products = dbServer.GetCollection<Product>("products");
            ObjectId objectID = new ObjectId();

            if (searchField == "_id" && ObjectId.TryParse(searchString, out objectID))
            {
                result = products.Find(new QueryDocument(searchField, new ObjectId(searchString)));
            }
            else
            {
                result = products.Find(new QueryDocument(searchField, searchString));
            }

            return result.ToList<Product>();
        }

        public List<Product> GetProducts()
        {
            List<Product> result = dbServer.GetCollection<Product>("products").FindAll().ToList<Product>();
            return result;
        }

        public List<Product> GetProductsByCategory(string categoryId)
        {
            MongoCollection<Product> products = dbServer.GetCollection<Product>("products");
            var result = products.Find(new QueryDocument("Category", categoryId));

            return result.ToList<Product>();
        }

        public string InsertCategory(Category category)
        {
            MongoCollection<Category> categories = dbServer.GetCollection<Category>("categories");
            categories.Insert<Category>(category);

            return category._id.ToString();
        }

        public void DeleteCategory(string categoryId)
        {
            MongoCollection<Product> products = dbServer.GetCollection<Product>("products");

            List<Product> selectedProd = products.Find(new QueryDocument("Category", categoryId)).ToList<Product>();
            if (selectedProd != null && selectedProd.Count() > 0)
            {
                foreach (var item in selectedProd)
                {
                    products.Remove(new QueryDocument("_id", new ObjectId(item._id)));
                }
            }

            MongoCollection<Category> categories = dbServer.GetCollection<Category>("categories");
            var categoriesResult = categories.Remove(new QueryDocument("_id", new ObjectId(categoryId)));
        }

        public void UpdateCategory(Category category)
        {
            MongoCollection<Category> categories = dbServer.GetCollection<Category>("categories");
            categories.Save<Category>(category);
        }

        public string InsertProduct(Product product)
        {
            MongoCollection<Product> products = dbServer.GetCollection<Product>("products");
            products.Insert<Product>(product);

            return product._id.ToString();
        }

        public void DeleteProduct(string productId)
        {
            MongoCollection<Product> products = dbServer.GetCollection<Product>("products");
            var result = products.Remove(new QueryDocument("_id", new ObjectId(productId)));
        }

        public void UpdateProduct(Product product)
        {
            MongoCollection<Product> products = dbServer.GetCollection<Product>("products");
            var result = products.Save<Product>(product);
        }


        List<Product> IMongoService.GetProductsByCategory(string category)
        {
            return this.GetProductsByCategory(category);
        }
    }
}
