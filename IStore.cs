//-----------------------------------------------------------------------
// <copyright file="IStore.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    /// <summary>
    /// I store is an interface
    /// </summary>
    public interface IStore
    {
        /// <summary>
        /// Visits the specified visitor.
        /// </summary>
        /// <param name="visitor">The visitor of interface type.</param>
        void Visit(IVisitor visitor);
    }
}
