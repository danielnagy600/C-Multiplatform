using System;

namespace Multiplatform
{
    public class Circle :IPlane
    {
        private int radius;

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public int Area()
        {
            return 2 * radius * (int)Math.PI;
        }
    }
}