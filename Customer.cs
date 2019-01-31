//-----------------------------------------------------------------------
// <copyright file="Customer.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;

    /// <summary>
    /// Customer class is an implementation class of an interface
    /// </summary>
    /// <seealso cref="DesignPatterns.ICustomer" />
    public class Customer : ICustomer
    {
        /// <summary>
        /// The name
        /// </summary>
        private string name;

        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        public Customer(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// Updates the specified product.
        /// </summary>
        /// <param name="product">The product.</param>
        public void Update(Product product)
        {
            Console.WriteLine("{0}: {1} Laptop is now available at {2}; Discount = {3}%", this.name, product.Name, product.CurrentPrice, product.Discount);
        }
    }
}
