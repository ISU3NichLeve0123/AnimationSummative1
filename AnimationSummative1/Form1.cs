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
            BackgroundImage = null;
            nameLabel.Dispose();
            cardLabel.Dispose();
            animationButton.Visible = true;
            Refresh();
        }

        private void AnimationButton_Click(object sender, EventArgs e)
        {
            Graphics fg = this.CreateGraphics();
            Pen whitePen = new Pen(Color.White, 10);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            animationButton.Dispose();
            SoundPlayer startUp = new SoundPlayer(Properties.Resources.Computer_Start_Up_Your_Mom_1280862923);
            startUp.PlaySync();
            this.BackColor = Color.Black;
            fg.DrawEllipse(whitePen, 58, 67, 120, 110);
            fg.FillEllipse(whiteBrush, 58, 67, 120, 110);
            fg.DrawEllipse(whitePen, 74, 104, 80, 80);
            fg.FillEllipse(whiteBrush, 74, 104, 80, 80);
        }
    }
}
