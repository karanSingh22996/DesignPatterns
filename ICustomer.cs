//-----------------------------------------------------------------------
// <copyright file="ICustomer.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    /// <summary>
    /// ICustomer interface
    /// </summary>
    public interface ICustomer
    {
        /// <summary>
        /// Updates the specified product.
        /// </summary>
        /// <param name="product">The product.</param>
        void Update(Product product);
    }
}
