//-----------------------------------------------------------------------
// <copyright file="Carrots.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    /// <summary>
    /// Carrots is an inherited class
    /// </summary>
    /// <seealso cref="DesignPatterns.Veggies" />
    public class Carrots : Veggies
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Carrots"/> class.
        /// </summary>
        /// <param name="price">The price.</param>
        public Carrots(double price) 
            : base(price)
        {
        }
    }
}
