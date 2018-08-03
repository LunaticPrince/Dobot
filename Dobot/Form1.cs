using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dobot
{
    public partial class Dobot : Form
    {
        public Dobot()
        {
            InitializeComponent();
            PnlSide.Location = new Point(PnlSide.Location.X, BtnGestion.Location.Y);
        }

        private void Dobot_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PnlSide.Location = new Point(PnlSide.Location.X, BtnGestion.Location.Y);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnPersonnages_Click(object sender, EventArgs e)
        {
            PnlSide.Location = new Point(PnlSide.Location.X, BtnPersonnages.Location.Y);
        }

        private void BtnEquipes_Click(object sender, EventArgs e)
        {
            PnlSide.Location = new Point(PnlSide.Location.X, BtnEquipes.Location.Y);
        }

        private void BtnModeAutomatique_Click(object sender, EventArgs e)
        {
            PnlSide.Location = new Point(PnlSide.Location.X, BtnModeAutomatique.Location.Y);
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}