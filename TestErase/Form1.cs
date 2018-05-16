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

namespace TestErase
{
    public partial class Form1 : Form
    {
        Point lastPoint = Point.Empty;//Point.Empty represents null for a Point object

        bool isMouseDown = new Boolean();//this is used to evaluate whether our mousebutton is down or not
        bool isErase = new Boolean();

        public Form1()
        {
            InitializeComponent();
            // Set default colours
            pb_Draw.BackColor = Color.Black;
            // create blank canvas 
            pb_Erase.BackColor = Color.White;
            trackBar1.Maximum = 10;
            trackBar1.Minimum = 1;
            trackBar1.Value = 2;
            pb_Canvas.BackColor = pb_Erase.BackColor;

        }

        private void drawBrushSize(PaintEventArgs e, int brushSize)
        {
            pb_brushSize.BackColor = Color.White;

            // Create pen.
            Pen blackPen = new Pen(Color.Black, 1);

            int pb_width = pb_brushSize.Width;
            int pb_height = pb_brushSize.Height;

            // Create location and size of ellipse.
            int x = pb_width/2 - ((brushSize*2) / 2);
            int y = pb_height/2 - ((brushSize * 2) / 2);
            int width = brushSize*2;
            int height = brushSize*2;

            // Draw ellipse to screen.
            e.Graphics.DrawEllipse(blackPen, x, y, width, height);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pb_brushSize_Paint(object sender, PaintEventArgs e)
        {
            drawBrushSize(e, trackBar1.Value);

        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            pb_brushSize.Invalidate();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = pb_Draw.BackColor;
            DialogResult dr = colorDialog1.ShowDialog();
            if(dr == DialogResult.OK || dr == DialogResult.Yes)
            {
                pb_Draw.BackColor = colorDialog1.Color;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = pb_Erase.BackColor;
            DialogResult dr = colorDialog1.ShowDialog();
            if (dr == DialogResult.OK || dr == DialogResult.Yes)
            {
                pb_Erase.BackColor = colorDialog1.Color;
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (pb_Canvas.Image != null)
            {
                pb_Canvas.Image = null;
                Invalidate();
            }
        }

        private void pb_Canvas_MouseDown(object sender, MouseEventArgs e)
        {

            lastPoint = e.Location;//we assign the lastPoint to the current mouse position: e.Location ('e' is from the MouseEventArgs passed into the MouseDown event)

            isMouseDown = true;//we set to true because our mouse button is down (clicked)
            MouseButtons mb = e.Button;
            if (mb == MouseButtons.Right)
            {
                isErase = true;
            }
        }

        private void pb_Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown == true)//check to see if the mouse button is down
            {
                if (lastPoint != null)//if our last point is not null, which in this case we have assigned above
                {
                    if (pb_Canvas.Image == null)//if no available bitmap exists on the picturebox to draw on
                    {
                        //create a new bitmap
                        Bitmap bmp = new Bitmap(pb_Canvas.Width, pb_Canvas.Height);
                        pb_Canvas.Image = bmp; //assign the picturebox.Image property to the bitmap created
                    }

                    using (Graphics g = Graphics.FromImage(pb_Canvas.Image))
                    {//we need to create a Graphics object to draw on the picture box, its our main tool
                        //when making a Pen object, you can just give it color only or give it color and pen size
                        if(isErase) g.DrawLine(new Pen(pb_Erase.BackColor, trackBar1.Value * 2), lastPoint, e.Location);
                        else g.DrawLine(new Pen(pb_Draw.BackColor, trackBar1.Value*2), lastPoint, e.Location);
                        g.SmoothingMode = SmoothingMode.AntiAlias;
                        //this is to give the drawing a more smoother, less sharper look
                    }
                    pb_Canvas.Invalidate();//refreshes the picturebox
                    lastPoint = e.Location;//keep assigning the lastPoint to the current mouse position
                }
            }

        }

        private void pb_Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            isErase = false;
            lastPoint = Point.Empty;
            //set the previous point back to null if the user lets go of the mouse button
        }
    }
}
