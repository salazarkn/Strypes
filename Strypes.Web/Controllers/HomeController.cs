using Strypes.Web.Models;
using Strypes.Web.MongoService;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Strypes.Web.Controllers
{
    public class HomeController : Controller
    {
        private MongoServiceClient client = new MongoServiceClient();

        public ActionResult Search()
        {
            return View();
        }


        public JsonResult SearchBy(string table, string col, string search)
        {
            object result = new Object();

            if (table == "Category")
            {
                if (col == "ID")
                {
                    result = new
                    {
                        Table = table,
                        Records = GetCategoryById(search)
                    };
                }
                else if (col == "Name")
                {
                    result = new
                    {
                        Table = table,
                        Records = client.GetCategories().Where(e => e.Name == search).ToList()
                    };
                }
            }
            else if (table == "Product")
            {
                if (col == "ID")
                {
                    result = new
                    {
                        Table = table,
                        Records = GetProductById(search)
                    };
                }
                else if (col == "Name")
                {
                    result = new
                    {
                        Table = table,
                        Records = client.GetProducts().Where(e => e.Name == search).ToList()
                    };
                }
            }



            return new JsonResult()
            {
                JsonRequestBehavior = JsonRequestBehavior.AllowGet,
                Data = result
            };
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Products()
        {
            return View();
        }

        public JsonResult GetProductsByCategory(string category)
        {
            List<Product> result = client.GetProductsByCategory(category);

            return new JsonResult()
            {
                JsonRequestBehavior = JsonRequestBehavior.AllowGet,
                Data = result
            };
        }

        public JsonResult GetProducts(string searchField, string searchString)
        {
            List<object> result = new List<object>();
            List<Product> products;
            List<Category> categories = client.GetCategories();

            if (!string.IsNullOrEmpty(searchField) && !string.IsNullOrEmpty(searchString))
            {
                if (searchField == "CategoryName")
                {
                    Category searchedCategories = categories.Where(s => s.Name == searchString).FirstOrDefault();
                    if (searchedCategories != null)
                    {
                        products = client.GetProductsBy("Category", searchedCategories._id);
                        foreach (var item in products)
                        {
                            result.Add(new
                            {
                                _id = item._id,
                                Category = item.Category,
                                CategoryName = categories.Where(c => c._id == item.Category).Select(s => s.Name),
                                Description = item.Description,
                                Image = item.Image,
                                Name = item.Name
                            });
                        }
                    }
                }
                else
                {
                    products = client.GetProductsBy(searchField, searchString);
                    foreach (var item in products)
                    {
                        result.Add(new
                        {
                            _id = item._id,
                            Category = item.Category,
                            CategoryName = categories.Where(c => c._id == item.Category).Select(s => s.Name),
                            Description = item.Description,
                            Image = item.Image,
                            Name = item.Name
                        });
                    }
                }
            }
            else
            {
                products = client.GetProducts();
                foreach (var item in products)
                {
                    result.Add(new
                    {
                        _id = item._id,
                        Category = item.Category,
                        CategoryName = categories.Where(c => c._id == item.Category).Select(s => s.Name),
                        Description = item.Description,
                        Image = item.Image,
                        Name = item.Name
                    });
                }
            }

            return new JsonResult()
            {
                JsonRequestBehavior = JsonRequestBehavior.AllowGet,
                Data = result
            };
        }

        private Product GetProductById(string id)
        {
            return client.GetProducts().Where(e => e._id == id).FirstOrDefault();
        }

        [HttpGet]
        public ActionResult EditProduct(string id)
        {
            ProductModel pm = new ProductModel();
            Product p = GetProductById(id);
            ViewBag.FileName = p.Image;
            pm.Image = p.Image;
            pm.Name = p.Name;
            pm.Category = p.Category;
            pm.CategoryId = p.CategoryId;
            pm._id = p._id;
            pm.Description = p.Description;

            return View(pm);
        }

        [HttpPost]
        public ActionResult EditProduct(ProductModel productModel)
        {
            Product product = new Product();
            HttpPostedFileBase file = Request.Files["ImageUploader"];
            if ((file != null) && (file.ContentLength > 0) && !string.IsNullOrEmpty(file.FileName))
            {
                string fileContentType = file.ContentType;
                byte[] fileBytes = new byte[file.ContentLength];
                file.InputStream.Read(fileBytes, 0, Convert.ToInt32(file.ContentLength));
                ViewBag.FileName = file.FileName;
                product.Image = file.FileName;
                var fullPath = string.Format("~/Images/" + file.FileName);
                file.SaveAs(Server.MapPath(fullPath));
            }


            product.Category = productModel.Category;
            product.CategoryId = productModel.CategoryId;
            product._id = productModel._id;
            product.Name = productModel.Name;
            product.Description = productModel.Description;




            client.UpdateProduct(product);
            return RedirectToAction("Products");
        }

        public JsonResult DeleteProduct(string id)
        {
            client.DeleteProduct(id);

            return new JsonResult()
            {
                JsonRequestBehavior = JsonRequestBehavior.AllowGet,
                Data = true
            };
        }

        [HttpGet]
        public ActionResult AddProduct(string id)
        {
            Category p = GetCategoryById(id);
            ViewBag.CategoryId = p._id;
            ViewBag.Category = p.Name;
            return View();
        }

        [HttpPost]
        public ActionResult AddProduct(Product product)
        {
            HttpPostedFileBase file = Request.Files["ImageUploader"];

            if ((file != null) && (file.ContentLength > 0) && !string.IsNullOrEmpty(file.FileName))
            {
                string fileFileName = file.FileName.Split('\\').LastOrDefault();
                string fileContentType = file.ContentType;
                byte[] fileBytes = new byte[file.ContentLength];
                file.InputStream.Read(fileBytes, 0, Convert.ToInt32(file.ContentLength));
                ViewBag.FileName = fileFileName;
                product.Image = fileFileName;
                var fullPath = string.Format("~/Images/" + fileFileName);
                file.SaveAs(Server.MapPath(fullPath));
            }

            Category result = client.GetCategories().Where(e => e._id == product.CategoryId).FirstOrDefault();
            if (result != null)
            {
                product.Category = result.Name;
            }
            string id = client.InsertProduct(product);

            return RedirectToAction("Products", new { id = product.CategoryId });
        }

        private Category GetCategoryById(string id)
        {
            return client.GetCategories().Where(e => e._id == id).FirstOrDefault();
        }



        public JsonResult GetCategories()
        {
            List<Category> result = client.GetCategories();

            return new JsonResult()
            {
                JsonRequestBehavior = System.Web.Mvc.JsonRequestBehavior.AllowGet,
                Data = result
            };
        }

        public JsonResult AddCategory(Category category)
        {
            string result = client.InsertCategory(category);

            return new JsonResult()
            {
                JsonRequestBehavior = JsonRequestBehavior.AllowGet,
                Data = result
            };
        }

        public JsonResult DeleteCategory(string id)
        {
            client.DeleteCategory(id);

            return new JsonResult()
            {
                JsonRequestBehavior = JsonRequestBehavior.AllowGet,
                Data = true
            };
        }

        public JsonResult EditCategory(Category category)
        {
            client.UpdateCategory(category);

            return new JsonResult()
            {
                JsonRequestBehavior = JsonRequestBehavior.AllowGet,
                Data = true
            };
        }
    }
}
