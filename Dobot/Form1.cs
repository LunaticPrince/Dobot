using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Dobot
{
    public partial class DobotForm : Form
    {
        public DobotForm()
        {
            InitializeComponent();
            PnlSide.Location = new Point(PnlSide.Location.X, BtnGestion.Location.Y);
        }

        private void Dobot_Load(object sender, EventArgs e)
        {
            
        }

        public new void Update()
        {
            if (Keyboard.IsKeyDown(Key.A))
            {
                label1.Text = "A";
            }
            else
            {
                label1.Text = "Personnages";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            PnlSide.Location = new Point(PnlSide.Location.X, BtnGestion.Location.Y);
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