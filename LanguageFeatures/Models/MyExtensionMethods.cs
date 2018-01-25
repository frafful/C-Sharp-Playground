﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
    public static class MyExtensionMethods
    {
        public static decimal TotalPrices(this IEnumerable<Product> products)
        {
            decimal total = 0;
            foreach (Product prod in products)
            {
                total += prod?.Price ?? 0;
            }

            return total;
        }

        public static IEnumerable<Product> FilterByPrice(this IEnumerable<Product> productEnum, decimal minPrice)
        {
            foreach (Product prod in productEnum)
            {
                if((prod?.Price ?? 0) >= minPrice)
                {
                    yield return prod;
                }
            }
        }

        public static IEnumerable<Product> Filter(this IEnumerable<Product> prodEnum, Func<Product, bool> selector)
        {
            foreach (Product prod in prodEnum)
            {
                if(selector(prod))
                {
                    yield return prod;
                }
            }
        }
    }
}
