using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallsPBox
{
    public partial class PDraw : UserControl
    {
        //   List<PBall> Balls = new List<PBall>();

        public PDraw()
        {
            InitializeComponent();

        }
        Random rand = new Random(DateTime.Now.Millisecond);

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            tMove.Enabled = true;
            pictureBox1.Controls.Add(new PBall(e.X, e.Y));
          //  pictureBox1.Invalidate();
        }

        private void tMove_Tick(object sender, EventArgs e)
        {
            pictureBox1.Controls.OfType<PBall>().Select(x => x).ToList().ForEach(x => x.MoveBall());
            pictureBox1.Invalidate(); // Перерисовка
        }

/*
        private void Speed(object sender, EventArgs e)
        {
            tMove.Interval = rand.Next(50, 100); ; // Скорость
        }*/

    }
}
