using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            label1.Dispose();
            Refersh();
        }
    }
}
