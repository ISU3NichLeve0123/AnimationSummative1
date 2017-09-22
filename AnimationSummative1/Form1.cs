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
            SolidBrush greenBrush = new SolidBrush(Color.Green);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            Font tittleFont = new Font("Arial", 10, FontStyle.Bold);
            Font paragraphFont = new Font("Courier New", 6,FontStyle.Italic);
            SoundPlayer startUp = new SoundPlayer(Properties.Resources.Computer_Start_Up_Your_Mom_1280862923);
            startUp.PlaySync();
            animationButton.Dispose();

            //Showing and drawing  the constellation Libra
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

            //Drawing the tittle and Paragraph for libra and playign the  taDa sound
            fg.DrawString("Libra:The Scales Of Balance", tittleFont, greenBrush, 30, 10);
            Thread.Sleep(2000);
            fg.DrawString("Libra:This constellation stands for law, balance, ", paragraphFont, yellowBrush, 0, 210);
            Thread.Sleep(1000);
            fg.DrawString(" and justice.The altertanite name for libra is scorpions claw. ", paragraphFont, yellowBrush, 0, 230);
            Thread.Sleep(1000);
            fg.DrawString(" and this is my birth zodiac sign. ", paragraphFont, yellowBrush, 0, 245);
            SoundPlayer taDa = new SoundPlayer(Properties.Resources.Ta_Da_SoundBible_com_1884170640);
            taDa.PlaySync();
            Thread.Sleep(60000);
        }
    }
}
