using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadtree
{
    internal class Node
    {
        public bool IsHomogenous { get; set; }
        public Color Color { get; set; }
        public Node Zero { get; set; }
        public Node First { get; set; }
        public Node Second { get; set; }
        public Node Third { get; set; }
    }
}
