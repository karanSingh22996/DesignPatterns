using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class RealPolygon : IShape
    {
        public string GetShape()
        {
            return "This is Polygon shape from real/actual class";
        }
        public void Details()
        {
            Console.WriteLine("This is real ploygon class");
        }
    }
}
