using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace CsharpAvanz.Models
{
    public  static class  MyExtensionMethods
    {
        public static float TotalPrice(this ShoppingCart cartParam) {
            float total =0;
            foreach(Product prod in cartParam.Products){
               total += prod.Price;
            }
            return total;
        }
    }
}