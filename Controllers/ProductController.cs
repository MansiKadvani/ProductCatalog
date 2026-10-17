using ProductCatalog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductCatalog.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            List<ProductModel> products = getProducts();

            return View(products);
        }

        public ActionResult Details(int id)
        {
            List<ProductModel> products = getProducts();
            ProductModel p1 = new ProductModel();
            p1 = products.FirstOrDefault(m => m.Id == id);
            return View(p1);
        }

        private List<ProductModel> getProducts()
        {
            List<ProductModel> products = new List<ProductModel>();

            ProductModel p1 = new ProductModel
            {
                Id = 1,
                Name = "Apple Watch",
                Description = "Description for product 1",
                Price = 50000,
                Image = "https://goodmockups.com/wp-content/uploads/2026/03/Free-Apple-Watch-Series-11-Mockup-PSD-324x235.jpg",
                Quantity = 30
            };

            ProductModel p2 = new ProductModel
            {
                Id = 2,
                Name = "Guccie Ophidia mini bag",
                Description = "Description for product 2",
                Price = 90000,
                Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQZ4pszzgQXpD5ybsu2TUlVqXvJj24htF744RBdWeTnLwJE9duMZ19QE7mi&s=10",
                Quantity = 21
            };

            ProductModel p3 = new ProductModel
            {
                Id = 3,
                Name = "Hyphen Sunscreen SPF 70+",
                Description = "Description for product 3",
                Price = 499,
                Image = "https://encrypted-tbn1.gstatic.com/shopping?q=tbn:ANd9GcQXITGGZXhl8hRSpun5P84NPyYaPJgzNUteBm5lTbxtBij7uKKFzhP8Qyq2aRHsZWu7evgGBK-y4PR1cbP6KI-JmAo1Nl1Xfq8gdN0_iS_ZPEv68-Ec2zLy6A&usqp=CAc",
                Quantity = 12
            };

            products.Add(p1);
            products.Add(p2);
            products.Add(p3);

            return products;
        }
    }
}