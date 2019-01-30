//-----------------------------------------------------------------------
// <copyright file="VendorAdapter.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;
    using System.Collections.Generic;
    public class VendorAdapter : VendorAdaptee, ITarget2
    {
        public List<string> GetProducts()
        {
            VendorAdaptee vendorAdaptee = new VendorAdaptee();
            return vendorAdaptee.GetListOfProducts();
        }
        public void SellingItems()
        {
            ITarget2 target2 = new VendorAdapter();
            foreach(string items in target2.GetProducts())
            {
                Console.WriteLine(items);
            }
        }
    }
}
