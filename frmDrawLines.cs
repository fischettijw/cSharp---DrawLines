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

        int numOfLines, angle, length, increment = 0;

        private void frmDrawLines_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
        }

        public frmDrawLines()
        {
            InitializeComponent();
        }

        private void btnGO_Click(object sender, EventArgs e)
        {
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
            
        }
    }
}
