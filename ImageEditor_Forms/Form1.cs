using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageEditor_Forms
{
    public partial class Form1:Form
    {
        Button pressedButton;
        Point lastPoint, startPoint;
        bool hold = false;
        public Form1()
        {
            InitializeComponent();
            Color_indicator.BackColor=Color.Black;
            Canvas.BackColor=Color.White;
            Canvas.Image = new Bitmap(Canvas.Width, Canvas.Height);
            foreach(Control button in this.Controls) {
                if(button is Button) {
                    button.Click += Button_Click;
                    button.BackColor = Button.DefaultBackColor;
                }
            }
            pressedButton = Point_button;
            Point_button.BackColor = Color.LightBlue;
            this.Resize+=Form1_Resize;

            Canvas.MouseMove += Canvas_MouseMove;
            Canvas.MouseDown += Canvas_MouseDown;
            Canvas.MouseUp += Canvas_MouseUp;
        }

        private void Form1_Resize(object sender, EventArgs e){
            Canvas.Width = Width-116;
            Canvas.Height = Height-63;
            Bitmap bmp = new Bitmap(Canvas.Width, Canvas.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.DrawImageUnscaled(Canvas.Image, 0, 0, Canvas.Width, Canvas.Height);
            Canvas.Image = new Bitmap(Canvas.Width, Canvas.Height, g);
            //TODO:naprawic skalowanie bo chuj czysci sie przy zmianie rozmiaru
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            lastPoint=Point.Empty;
            hold=false;
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            hold = true;
            lastPoint = e.Location;
            startPoint=e.Location;
        }

        bool performOneTickWork = false;
        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            int thickness = (int)LineThickness_numeric.Value;
            Color color = Color_indicator.BackColor;
            using (Graphics g = Graphics.FromImage(Canvas.Image))
            if (Control.MouseButtons == MouseButtons.Left) {
                if (Canvas.Image != null) {
                        switch (pressedButton.Name) {
                            case "Point_button":
                                g.SmoothingMode = SmoothingMode.AntiAlias;
                                //g.DrawEllipse(new Pen(color, thickness), lastPoint.X-(thickness/2)+1, lastPoint.Y-(thickness/2)+1, (thickness/2), (thickness/2));
                                g.DrawLine(new Pen(color, thickness), lastPoint, e.Location);
                                Canvas.Invalidate();
                                break;
                            case "Circle_button":
                                performOneTickWork=true;
                                break;
                        }
                    lastPoint=e.Location;
                }
            }else if (performOneTickWork)
                switch (pressedButton.Name) {
                    case "Circle_button":
                        int _width = lastPoint.X - e.Location.X; if (_width < 0) _width *= -1;
                        int _height = lastPoint.Y - e.Location.Y; if (_height < 0) _height *= -1;
                        int dim;
                        if (_width < _height) dim = _width; else dim = _height;
                        if (!hold) {
                            g.DrawEllipse(new Pen(color, thickness), lastPoint.X, lastPoint.Y, dim, dim);
                            Canvas.Invalidate();
                        }
                        break;
                }
                performOneTickWork =false;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            foreach (Control button in this.Controls) {
                if (button is Button ) {
                    if(button.BackColor==Color.LightBlue && (sender as Button).Name != Color_button.Name) {
                        button.BackColor=Button.DefaultBackColor;
                        (sender as Button).BackColor = Color.LightBlue;
                        pressedButton = sender as Button;
                        break;
                    } else if ((sender as Button).Name == Color_button.Name) {
                        if (colorDialog1.ShowDialog() == DialogResult.OK) {
                            Color_indicator.BackColor=colorDialog1.Color;
                        }
                        break;
                    }
                }
            }
            
        }
    }
}
