using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharp___DrawLines
{
    public partial class frmDrawLines : Form
    {
        Pen myPen = new Pen(Brushes.Black, 1);
        Graphics g = null;

        int xCenter, yCenter;
        int xStart, yStart;
        int xEnd, yEnd;

        int numOfLines, angle, angleOrig, length, increment = 0;

        private void frmDrawLines_Resize(object sender, EventArgs e)
        {
            frmDrawLines_Load(null, null);
            btnGO_Click(null, null);
        }

        private void frmDrawLines_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            xCenter = pnlCanvas.Width / 2;
            yCenter = pnlCanvas.Height / 2;
            xStart = xCenter;
            yStart = yCenter;
            xEnd = xCenter;
            yEnd = yCenter;
        }

            public frmDrawLines()
        {
            InitializeComponent();
        }

        private void btnGO_Click(object sender, EventArgs e)
        {
            numOfLines = int.Parse(txtNumOfLines.Text);
            angle = int.Parse(txtAngle.Text);
            angleOrig = angle;
            length = int.Parse(txtLength.Text);
            increment = int.Parse(txtIncrement.Text);
            xStart = xCenter;
            yStart = yCenter;

            pnlCanvas.Refresh();
        }

        private void pnlCanvas_Paint(object sender, PaintEventArgs e)
        {
            xCenter = pnlCanvas.Width / 2;
            yCenter = pnlCanvas.Height / 2;

            if (numOfLines > 0)
            {
                g = e.Graphics;
                for (int k = 0; k < numOfLines; k++)
                {
                    drawLine();
                }
            }
        }

        private void drawLine()
        {
            xEnd = (int)xStart + Convert.ToInt32(Math.Cos(deg2rad(angle)) * length);
            yEnd = (int)yStart + Convert.ToInt32(Math.Sin(deg2rad(angle)) * length);
            g.DrawLine(myPen, xStart, yStart, xEnd, yEnd);
            angle += angleOrig;
            length += increment;
            xStart = xEnd;
            yStart = yEnd;
        }
        
        private double deg2rad(double degrees)
        {
            double radians = (Math.PI / 180) * degrees;
            return (radians);
        }
    }
}
