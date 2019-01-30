//-----------------------------------------------------------------------
// <copyright file="VendorAdaptee.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System.Collections.Generic;
    public class VendorAdaptee
    {
        public List<string> GetListOfProducts()
        {
            List<string> products = new List<string>();
            products.Add("Television");
            products.Add("Gaming Kit");
            products.Add("Mobiles");
            products.Add("Hp Laptops");
            return products;
        }
    }
}
