using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dolce
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
            this.CenterToScreen();
            loadq = new Rectangle(1, this.Height / 2, 20, 20);
            Loading_Load(this,e);
        }
        Pen red = new Pen(Color.Blue);
        System.Drawing.SolidBrush bluefill = new System.Drawing.SolidBrush(Color.CornflowerBlue);
        Rectangle loadq;

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if(loadq.X > this.Width)
            {
                timer1.Stop();
                this.Close();
            }
            loadq.X += 10;
            Invalidate();
        }

        private void Loading_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawRectangle(red, loadq);
            g.FillRectangle(bluefill, loadq);
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            
        }
    }
}
