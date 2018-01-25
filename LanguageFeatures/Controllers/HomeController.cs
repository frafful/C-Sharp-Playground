using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ViewResult> Index()
        {
            long? length = await MyAsyncMethods.GetPageLength();
            return View(new string[] { $"Length: {length}" });
        }
        
        //bool FilterByPrice(Product p)
        //{
        //    return (p?.Price ?? 0) >= 20;
        //}

        //public IActionResult Index()
        //{
        //    ShoppingCart cart = new ShoppingCart
        //    {
        //        Products = Product.GetProducts()
        //    };

        //    Product[] productArray =
        //    {
        //        new Product { Name = "Kayak", Price = 275m },
        //        new Product { Name = "Lifejacket", Price = 48.95m },
        //        new Product { Name = "Soccer ball", Price = 19.50m },
        //        new Product { Name = "Corner flag", Price = 48.95m }
        //    };

        //    Func<Product, bool> nameFilter = delegate (Product prod)
        //    {
        //        return prod?.Name?[0] == 'S';
        //    };

        //    decimal priceFilterTotal = productArray.Filter(FilterByPrice).TotalPrices();
        //    decimal nameFilterTotal = productArray.Filter(nameFilter).TotalPrices();

        //    return View("Index", new string[] {
        //        $"Price Total: {priceFilterTotal:c2}",
        //        $"Array Total: {nameFilterTotal:c2}"
        //    });


            //ShoppingCart cart = new ShoppingCart
            //{
            //    Products = Product.GetProducts()
            //};
            //decimal cartTotals = cart.TotalPrices();

            //return View("Index", new string[] { $"Total: {cartTotals:c2}" });
            
            //Dictionary<string, Product> products = new Dictionary<string, Product>
            //{
            //    ["Kayak"] = new Product { Name = "Kayak", Price = 275m },
            //    ["Lifejacket"] = new Product { Name = "Lifejacket", Price = 48.95m }
            //};

            //return View("Index", products.Keys);
            
            //List<string> results = new List<string>();

            //foreach (Product p in Product.GetProducts())
            //{
            //    string name = p?.Name ?? "<No Name>";
            //    decimal? price = p?.Price ?? 0;
            //    string relatedName = p?.Related?.Name ?? "<None>";
            //    results.Add($"Name: {name}, Price: {price}, Related: {relatedName}");
            //}

            //return View(results);
        //}
    }
}