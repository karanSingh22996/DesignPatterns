//-----------------------------------------------------------------------
// <copyright file="IProduct.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    /// <summary>
    /// IProduct interface
    /// </summary>
    public interface IProduct
    {
        /// <summary>
        /// Subscribes the specified customer.
        /// </summary>
        /// <param name="customer">The customer.</param>
        void Subscribe(Customer customer);

        /// <summary>
        /// the Unsubscribe.
        /// </summary>
        /// <param name="customer">The customer of type Customer.</param>
        void UnSubscribe(Customer customer);

        /// <summary>
        /// Notifies this instance.
        /// </summary>
        void Notify();
    }
}
