using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractalMaker
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        List<Color> colors = new List<Color>() { Color.Blue, Color.Red, Color.Yellow, Color.Green, Color.Lime };
        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void btnFractal_Click(object sender, EventArgs e)
        {
            FractalForm f = new FractalForm();
            f.ShowDialog();
        }
    }
}
