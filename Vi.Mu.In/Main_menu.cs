using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vi.Mu.In
{
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            Title.Parent = pictureBox1;
            Title.BackColor = Color.Transparent;
        }

        private void pianobtn_Click(object sender, EventArgs e)
        {
            Piano newform = new Piano();
            this.Hide();
            newform.ShowDialog();
            this.Show();
        }

        private void drumpadbtn_Click(object sender, EventArgs e)
        {
            Drum_pad newform = new Drum_pad();
            this.Hide();
            newform.ShowDialog();
            this.Show();
        }
    }
}
