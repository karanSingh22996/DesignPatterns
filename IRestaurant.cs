//-----------------------------------------------------------------------
// <copyright file="IRestaurant.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    /// <summary>
    /// I restaurant is an interface
    /// </summary>
    public interface IRestaurant
    {
        /// <summary>
        /// Updates the specified veggie.
        /// </summary>
        /// <param name="veggie">The veggie.</param>
        void Update(Veggies veggie);
    }
}
