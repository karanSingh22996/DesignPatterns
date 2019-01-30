//-----------------------------------------------------------------------
// <copyright file="Customer.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;
    public class Customer : ICustomer
    {
        string name;
        public Customer(string name)
        {
            this.name = name;
        }
        public void Update(Product product)
        {
            Console.WriteLine("{0}: {1} Laptop is now available at {2}; Discount = {3}%", this.name, 
                product.Name, product.CurrentPrice, product.discount);

        }
    }
}
