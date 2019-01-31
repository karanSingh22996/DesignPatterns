//-----------------------------------------------------------------------
// <copyright file="IFactory.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    /// <summary>
    /// I factory is an interface
    /// </summary>
    public interface IFactory
    {
        /// <summary>
        /// Drives the specified miles.
        /// </summary>
        /// <param name="miles">The miles of type integer.</param>
        void Drive(int miles);
    }
}
