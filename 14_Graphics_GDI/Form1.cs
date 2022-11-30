using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_Graphics_GDI
{
    public partial class Form1 : Form
    {
        enum ShapeType { Rectangle, Line , Ellipse};
        int redraw_count = 0;
        List<Point> points = new List<Point>();
        List<MyShape> shapes = new List<MyShape>();
        Point startLocation;
        public Form1()
        {
            InitializeComponent();
            colorCB.Items.Add(Color.Red);
            colorCB.Items.Add(Color.Green);
            colorCB.Items.Add(Color.Gray);
            colorCB.Items.Add(Color.Blue);
            colorCB.Items.Add(Color.Cyan);
            colorCB.SelectedIndex = 0;
            colorCB.Size = new Size(300, 50);
            foreach (var item in Enum.GetValues(typeof(ShapeType)))
            {
                figureCb.Items.Add(item);
            }
            figureCb.SelectedIndex = 0;
            figureCb.Size = new Size(300, 50);
        }

        private void DrawBtn_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            int x = 33, y = 43;
            int height = 120, width = 120;


            Pen pen = new Pen(Brushes.Red, 4);
          
            Point pt = new Point(10, 10);
            Size sz = new Size(320, 320);

            Rectangle rect1 = new Rectangle(pt, sz);
            Rectangle rect2 = new Rectangle(x,y,width, height);

            g.FillEllipse(Brushes.Green, rect1);
            g.DrawEllipse(pen, rect2);
        }

        private void PrintPoints(Graphics g)
        {
            foreach (Point p in points)
            {
                g.FillEllipse(Brushes.Red, p.X - 15, p.Y - 15, 30, 30);
            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach (var s in shapes)
            {
                //g.FillRectangle(new SolidBrush(r.Color), r.Rectangle);
                s.Draw(g);
            }

            //Draw Points
            //PrintPoints(e.Graphics);

            //draw line
            //using (Graphics g = e.Graphics)
            //{
            //    //Draw line
            //    Pen pen = new Pen(Color.Red, 20);
            //    pen.StartCap = System.Drawing.Drawing2D.LineCap.SquareAnchor;
            //    pen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            //    pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            //    pen.DashCap = System.Drawing.Drawing2D.DashCap.Round;
            //    g.DrawLine(pen, 20, 350, 600, 350);


            //    Point p = new Point(10, 10);
            //    Size size = new Size(320, 320);
            //    Rectangle rect = new Rectangle(p, size);
            //    g.DrawEllipse(pen, rect);
            //}//Dispose()


            //Draw ellipse
            //this.Text = $"{redraw_count++}";
            ////Graphics g = this.CreateGraphics();
            //Graphics g = e.Graphics;
            //int x = 33, y = 43;
            //int height = 120, width = 120;
            //Pen pen = new Pen(Brushes.Red, 4);
            //Point pt = new Point(10, 10);
            //Size sz = new Size(320, 320);
            //Rectangle rect1 = new Rectangle(pt, sz);
            //Rectangle rect2 = new Rectangle(x, y, width, height);
            //g.FillEllipse(Brushes.Green, rect1);
            //g.DrawEllipse(pen, rect2);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            //Point point = e.Location;
            //points.Add(point);

            //this.CreateGraphics().FillEllipse(Brushes.Red, point.X-15, point.Y-15, 30, 30);


        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            this.Text = "Down";
            startLocation = e.Location;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            this.Text = "Up";
            Point end = e.Location;
            Graphics g = this.CreateGraphics();
            Color color = (Color)colorCB.SelectedItem;
            SolidBrush brush = new SolidBrush(color);
            MyShape shape = null;
            var type = (ShapeType)figureCb.SelectedItem;
            if (type == ShapeType.Rectangle || type == ShapeType.Ellipse)
            {
                Rectangle rect = new Rectangle();
                rect.X = startLocation.X < end.X ? startLocation.X : end.X;
                rect.Y = startLocation.Y < end.Y ? startLocation.Y : end.Y;

                rect.Width = Math.Abs(e.X - startLocation.X);
                rect.Height = Math.Abs(e.Y - startLocation.Y);               

                if (type == ShapeType.Rectangle)
                    shape = new MyRectangle(rect, color);
                else
                    shape = new MyEllipse(rect, color);
              
            }
            else if(type == ShapeType.Line)
            {
                shape = new MyLine(color,  startLocation,end);
               
            }
            shape.Draw(g);
            shapes.Add(shape);
        }
    }
    abstract class MyShape
    {
        public abstract void Draw(Graphics g);
    }
    class MyRectangle :MyShape
    {
        public Color Color { get; set; }
        public Rectangle Rectangle { get; set; }
        public MyRectangle() {  }
        public MyRectangle(Rectangle R ,Color C)
        {
            Color = C;
            Rectangle = R;
        }

        public override void Draw(Graphics g)
        {
            g.FillRectangle(new SolidBrush(Color), Rectangle);
        }
    }
    class MyEllipse :MyRectangle
    {
      
        public MyEllipse() { }
        public MyEllipse(Rectangle R, Color C): base(R, C) { }
     
        public override void Draw(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color), Rectangle);
        }
    }
    class MyLine : MyShape
    {
        public Pen Pen { get; set; }
        public Point Start { get; set; }
        public Point End { get; set; }
        public MyLine(){     }
        public MyLine(Color c, Point s, Point e)
        {
            Pen = new Pen(c);
            Start = s;
            End = e;
        }
        public override void Draw(Graphics g)
        {
            g.DrawLine(Pen, Start, End);
        }
    }
}
