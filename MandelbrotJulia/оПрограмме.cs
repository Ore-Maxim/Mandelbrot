using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class оПрограмме : Form
    {
        public оПрограмме()
        {
            InitializeComponent();
        }

        public Mandelbrot Mandelbrot
        {
            get => default;
            set
            {
            }
        }

        private void оПрограмме_Load(object sender, EventArgs e)
        {
            ClientSize = new Size(780, 450);
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void вернутьсяВМеняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Mandelbrot mandelbrot = new Mandelbrot(0,0);
            mandelbrot.ShowDialog();
            Close();
        }
    }
}
