//-----------------------------------------------------------------------
// <copyright file="ITarget2.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System.Collections.Generic;

    /// <summary>
    /// I target is an interface
    /// </summary>
    public interface ITarget2
    {
        /// <summary>
        /// Gets the products.
        /// </summary>
        /// <returns>list of string</returns>
        List<string> GetProducts();
    }
}
