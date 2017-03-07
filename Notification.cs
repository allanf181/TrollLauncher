using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrollLauncher
{
    public partial class Notification : Form
    {
        Form1 form = null;
        public Notification()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                ExtractIcon(path);
            }
        }

        private void ExtractIcon(string filePath)
        {
            Icon ico = Icon.ExtractAssociatedIcon(filePath);
            pictureBox1.Image = ico.ToBitmap();
            labelLocal.Text = filePath;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxUsarPadrao.Checked)
            {   
                this.btnSelecionarIcon.Enabled = false;
                this.textBoxTitulo.Enabled = false;
                this.textBoxBtnNome.Enabled = false;
            }
            else
            {
                this.btnSelecionarIcon.Enabled = true;
                this.textBoxTitulo.Enabled = true;
                this.textBoxBtnNome.Enabled = true;
            }
        }
    }
}
