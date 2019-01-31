//-----------------------------------------------------------------------
// <copyright file="ProxyPolygon.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;

    /// <summary>
    /// Proxy polygon is an implementation class an interface
    /// </summary>
    /// <seealso cref="DesignPatterns.IShape" />
    public class ProxyPolygon : IShape
    {
        /// <summary>
        /// The shape
        /// </summary>
        private IShape shape;

        /// <summary>
        /// Gets the shape.
        /// </summary>
        /// <returns>
        /// String return.
        /// </returns>
        public string GetShape()
        {
            this.shape = new RealPolygon();
            return this.shape.GetShape();
        }

        /// <summary>
        /// Details this instance.
        /// </summary>
        public void Details()
        {
            Console.WriteLine("This is proxy polygon class");
        }

        /// <summary>
        /// Proxies the runner.
        /// </summary>
        public void ProxyRunner()
        {
            ProxyPolygon proxyPolygon = new ProxyPolygon();
            proxyPolygon.Details();
            string realPolygonDetails = proxyPolygon.GetShape();
            Console.WriteLine(realPolygonDetails);
            Console.ReadLine();
        }
    }
}
