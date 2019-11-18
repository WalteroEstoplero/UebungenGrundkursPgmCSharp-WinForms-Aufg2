using System.Drawing;
using System.Windows.Forms;

namespace UebungenGrundkursPgmCSharp_WinForms_Aufg2
{
    public partial class Form1 : Form
    {
        int x = 400;
        int y = 200;
        int width = 40;
        int height = 40;

        int dx;
        int dy;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Rechteck verschieben";
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics gra = e.Graphics;

            e.Graphics.FillRectangle(new SolidBrush(Color.Blue), x+dx, y+dy, width, height);
        }

        private void Btn_left_Click(object sender, System.EventArgs e)
        {
            if (dx > -300) dx -= 20;
            this.Refresh();
        }

        private void Btn_right_Click(object sender, System.EventArgs e)
        {

            if (dx < 300) dx += 20;
            this.Refresh();
        }

        private void Btn_top_Click(object sender, System.EventArgs e)
        {
            if (dy > -220) dy -= 20;
            this.Refresh();
        }
        private void Btn_down_Click(object sender, System.EventArgs e)
        {
            if (dy < 200) dy += 20;
            this.Refresh();
        }

    }
}
