using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCSharp
{
    public class Point3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point3D(double x,double y,double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public override string ToString()
        {
            return String.Format("{0}, {1}, {2}", this.X, this.Y, this.Z);
        }

        public override bool Equals(object obj)
        {
            //
            return base.Equals(obj);
        }
    }
}
