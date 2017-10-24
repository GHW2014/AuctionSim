using System;
using System.Drawing;
using System.Windows.Forms;

namespace AuctionSim
{
    public partial class InforBox : Form
    {
        public InforBox()
        {
            InitializeComponent();
        }

        public InforBox(MainForm f)
        {
            InitializeComponent();
            this.Owner = f;
            this.Location = new Point(f.Location.X + 430, f.Location.Y + 270);
        }

        public void OutputInfor(string str)
        {
            lblDisplay.Text = str;
            this.ShowDialog();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
