using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace SharpKML_Tutorial
{
    public partial class frmAddOnePointLocation : Form
    {
        // чтобы перетаскивать форму без внешних панелей
        bool drag = false;
        Point start_point = new Point(0, 0);

        public frmAddOnePointLocation()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bunifuGradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true; // drag is your variable flag.
            start_point = new Point(e.X, e.Y);
        }

        private void bunifuGradientPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void bunifuGradientPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtInsertCoordinats_Enter(object sender, EventArgs e)
        {
            txtInsertCoordinats.Text = "";
            txtInsertCoordinats.ForeColor = Color.Black;
            txtInsertCoordinats.Font =
                new System.Drawing.Font("Microsoft Sans Serif", 11F);
        }

        private void txtInsertCoordinats_Leave(object sender, EventArgs e)
        {
            if (txtInsertCoordinats.Text == "")
            {
                txtInsertCoordinats.Text = "Скопируйте координаты сюда...";
                txtInsertCoordinats.ForeColor = Color.DarkGoldenrod;
                txtInsertCoordinats.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic);
            }
        }
    }
}
