using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace Quadtree
{
    public partial class Main : Form
    {
        private ArrayList listSq;
        private Bitmap image;
        private Graphics graphics;
        private Node root;
        private int side;

        public Main()
        {
            this.InitializeComponent();

            this.root = null;
            this.side = this.pictureBox1.Width;
            this.image = new Bitmap(this.pictureBox1.Image);
            this.graphics = this.pictureBox2.CreateGraphics();
            this.graphics.Clear(Color.White);
        }

        private bool IsHomogenous(Bitmap bp, Square sq)
        {
            Color c = bp.GetPixel(sq.Corner.X, sq.Corner.Y);
            for (int i = sq.Corner.X; i < sq.Corner.X + sq.Side; i++)
            {
                for (int j = sq.Corner.Y; j < sq.Corner.Y + sq.Side; j++)
                {
                    if (c != bp.GetPixel(i, j))
                        return false;
                }
            }

            return true;
        }

        private ArrayList Subdivide(Square sq)
        {
            var list = new ArrayList();
            int halfSide = sq.Side / 2;

            list.Add(new Square(sq.Corner, halfSide));
            list.Add(new Square(new Point(sq.Corner.X + halfSide, sq.Corner.Y), halfSide));
            list.Add(new Square(new Point(sq.Corner.X + halfSide, sq.Corner.Y + halfSide), halfSide));
            list.Add(new Square(new Point(sq.Corner.X, sq.Corner.Y + halfSide), halfSide));

            foreach (Square s in list)
            {
                this.graphics.DrawRectangle(Pens.Black, s.Corner.X, s.Corner.Y, halfSide, halfSide);
            }
            return list;
        }

        private void OnButtonCreateTreeClick(object sender, EventArgs e)
        {
            this.graphics.Clear(Color.White);
            this.root = new Node();

            Square init = new Square(new Point(0, 0), this.side);
            this.root.Color = this.image.GetPixel(init.Corner.X, init.Corner.Y);
            if (this.IsHomogenous(image, init))
            {

                this.root.IsHomogenous = true;
                this.root.Zero = null;
                this.root.First = null;
                this.root.Second = null;
                this.root.Third = null;
            }
            else
            {
                this.root.IsHomogenous = false;
                this.listSq = Subdivide(init);
                this.root.Zero = AddNode((Square)listSq[0]);
                this.root.First = AddNode((Square)listSq[1]);
                this.root.Second = AddNode((Square)listSq[2]);
                this.root.Third = AddNode((Square)listSq[3]);
            }
        }

        private Node AddNode(Square sq)
        {
            var temp = new Node();
            temp.Color = image.GetPixel(sq.Corner.X, sq.Corner.Y);
            if (this.IsHomogenous(image, sq))
            {
                temp.IsHomogenous = true; //homogenous
                temp.Zero = null;
                temp.First = null;
                temp.Second = null;
                temp.Third = null;
                return temp;
            }
            else //not homogenous
            {
                temp.IsHomogenous = false; //not homogenous
                var newList = new ArrayList();
                newList = Subdivide(sq);
                temp.Zero = this.AddNode((Square)newList[0]);
                temp.First = this.AddNode((Square)newList[1]);
                temp.Second = this.AddNode((Square)newList[2]);
                temp.Third = this.AddNode((Square)newList[3]);
                return temp;
            }
        }

        private void OnButtonHomogenousClick(object sender, EventArgs e)
        {
            this.ResetSourceImage();
        }

        private void OnButtonHeterogenousLevel1Click(object sender, EventArgs e)
        {
            this.PaintSourceImage(50, 0, this.pictureBox1.Width, this.pictureBox1.Height / 2);
        }

        private void OnButtonHeterogenousLevel2Click(object sender, EventArgs e)
        {
            this.PaintSourceImage(0, 36, this.pictureBox1.Width / 4, this.pictureBox1.Height / 2);
        }

        private void OnButtonSelectFileClick(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var tempImage = Image.FromFile(dialog.FileName);
                var bitmap = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);
                using (var graph = Graphics.FromImage(bitmap))
                {
                    graph.FillRectangle(new SolidBrush(Color.White), 0, 0, this.pictureBox1.Width, this.pictureBox1.Height);
                    graph.DrawImage(tempImage, new Point(0, 0));
                }

                this.image = bitmap;
                this.pictureBox1.Image = bitmap;
            }
        }

        private void OnButtonFillTreeViewClick(object sender, EventArgs e)
        {
            this.treeViewSquares.Nodes.Clear();
            var rootNode = new TreeNode("Root");
            this.treeViewSquares.Nodes.Add(rootNode);
            this.FillTree(rootNode, this.root, 0);
        }

        private void FillTree(TreeNode sourceNode, Node source, int depth)
        {
            depth++;

            if (source == null)
                return;
            
            var nodeText = string.Format("Node zero: Depth: {0}, Color: {1}", depth, source.Color);
            var nodeZero = new TreeNode(nodeText);
            FillTree(nodeZero, source.Zero, depth);
            sourceNode.Nodes.Add(nodeZero);
            
            nodeText = string.Format("Node first: Depth: {0}, Color: {1}", depth, source.Color);
            var nodeFirst = new TreeNode(nodeText);
            FillTree(nodeFirst, source.First, depth);
            sourceNode.Nodes.Add(nodeFirst);

            nodeText = string.Format("Node second: Depth: {0}, Color: {1}", depth, source.Color);
            var nodeSecond = new TreeNode(nodeText);
            FillTree(nodeSecond, source.Second, depth);
            sourceNode.Nodes.Add(nodeSecond);

            nodeText = string.Format("Node third: Depth: {0}, Color: {1}", depth, source.Color);
            var nodeThird = new TreeNode(nodeText);
            FillTree(nodeThird, source.Third, depth);
            sourceNode.Nodes.Add(nodeThird);
        }

        private void ClearQuadTree()
        {
            this.graphics.Clear(Color.White);
        }

        private void PaintSourceImage(int x, int y, int width, int height)
        {
            this.ResetSourceImage();

            for (int i = x; i < width; i++)
            {
                for (int j = y; j < height; j++)
                {
                    image.SetPixel(i, j, Color.Red);
                }
            }

            this.pictureBox1.Image = image;
        }

        private void ResetSourceImage()
        {
            for (int i = 0; i < this.pictureBox1.Width; i++)
            {
                for (int j = 0; j < this.pictureBox1.Height; j++)
                {
                    image.SetPixel(i, j, Color.White);
                }
            }

            this.pictureBox1.Image = image;
        }
    }
}
