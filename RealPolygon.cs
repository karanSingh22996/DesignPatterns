//-----------------------------------------------------------------------
// <copyright file="RealPolygon.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;

    /// <summary>
    /// Real polygon is an implementation class of an interface shape
    /// </summary>
    /// <seealso cref="DesignPatterns.IShape" />
    public class RealPolygon : IShape
    {
        /// <summary>
        /// Gets the shape.
        /// </summary>
        /// <returns>
        /// String return.
        /// </returns>
        public string GetShape()
        {
            return "This is Polygon shape from real/actual class";
        }

        /// <summary>
        /// Details this instance.
        /// </summary>
        public void Details()
        {
            Console.WriteLine("This is real ploygon class");
        }
    }
}
