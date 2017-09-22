using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace AnimationSummative1
{
    public partial class GreetingCard : Form
    {
        public GreetingCard()
        {
            InitializeComponent();
            Graphics fg = this.CreateGraphics();
            Font drawFont = new Font("Arial", 70, FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.Red);


            fg.DrawString("Hello", drawFont, drawBrush, 600, 400);
        }

        private void GreetingCard_MouseClick(object sender, MouseEventArgs e)
        {
            //Getting rid of the tittle card and showing the chanegs
            BackgroundImage = null;
            nameLabel.Dispose();
            cardLabel.Dispose();
            animationButton.Visible = true;
            Refresh();
        }

        private void AnimationButton_Click(object sender, EventArgs e)
        {
            //Labeling the various objects used and playing a start sound
            Graphics fg = this.CreateGraphics();
            Pen whitePen = new Pen(Color.White,2);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            Pen blackPen = new Pen(Color.Black,5);
            Font TittleFont = new Font("Arial", 20, FontStyle.Bold);
            Font drawFont = new Font("Arial", 12,FontStyle.Italic);
            SoundPlayer startUp = new SoundPlayer(Properties.Resources.Computer_Start_Up_Your_Mom_1280862923);
            startUp.PlaySync();
            animationButton.Dispose();

            //Showing the drawing of the constellation
            fg.DrawEllipse(whitePen, 58, 67, 2, 4);
            fg.FillEllipse(whiteBrush, 58, 67, 2, 4);
            Thread.Sleep(600);
            fg.DrawEllipse(whitePen, 94, 140, 2, 4);
            fg.FillEllipse(whiteBrush, 94, 140, 4, 4);
            Thread.Sleep(600);
            fg.DrawLine(whitePen, 58, 67, 94, 140);
            Thread.Sleep(600);
            fg.DrawEllipse(whitePen, 94, 180, 2, 4);
            fg.FillEllipse(whiteBrush, 94, 180, 2, 4);
            Thread.Sleep(600);
            fg.DrawLine(whitePen,94, 140,94,180);
            Thread.Sleep(600);
            fg.DrawEllipse(whitePen, 120, 40, 2, 4);
            fg.FillEllipse(whiteBrush, 120, 40,2, 4);
            Thread.Sleep(600);
            fg.DrawLine(whitePen, 58, 67, 120, 40);
            Thread.Sleep(600);
            fg.DrawEllipse(whitePen, 170, 94, 2, 4);
            fg.FillEllipse(whiteBrush, 170, 94, 2, 4);
            Thread.Sleep(600);
            fg.DrawLine(whitePen,120 , 40, 170, 94);
            Thread.Sleep(600);
            fg.DrawLine(whitePen, 58,67, 170, 94);
            Thread.Sleep(600);
            fg.DrawEllipse(whitePen, 160, 190, 2, 4);
            fg.FillEllipse(whiteBrush, 160, 190, 2, 4);
            Thread.Sleep(600);
            fg.DrawLine(whitePen, 170, 94, 160, 190);
            Thread.Sleep(600);
            fg.DrawEllipse(whitePen, 170, 200, 2, 4);
            fg.FillEllipse(whiteBrush, 170, 200, 2, 4);
            Thread.Sleep(600);
            fg.DrawLine(whitePen, 160, 190, 170, 200);
            Thread.Sleep(600);
        }
    }
}
