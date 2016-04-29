using System.Drawing;

namespace Quadtree
{
    internal class Square
    {
        private Point corner;
        private int side;

        public Square(Point loc, int s)
        {
            this.corner = loc;
            this.side = s;
        }

        public int Side
        {
            get
            {
                return side;
            }

            set
            {
                side = value;
            }
        }

        public Point Corner
        {
            get
            {
                return corner;
            }

            set
            {
                corner = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Square[{0}, {1}], side={3})", this.Corner.X, this.Corner.Y, this.Side);
        }
    }
}
