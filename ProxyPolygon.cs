using System;
//-----------------------------------------------------------------------
// <copyright file="ProxyPolygon.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    public class ProxyPolygon : IShape
    {
        IShape _shape;
        public string GetShape()
        {
            _shape = new RealPolygon();
            return _shape.GetShape();
        }
        public void Details()
        {
            Console.WriteLine("This is proxy polygon class");
        }
        public void ProxyRunner()
        {
            ProxyPolygon proxyPolygon = new ProxyPolygon();
            proxyPolygon.Details();
            string RealPolygonDetails = proxyPolygon.GetShape();
            Console.WriteLine(RealPolygonDetails);
            Console.ReadLine();
        }
    }
}
