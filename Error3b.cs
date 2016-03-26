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

    public partial class Error3b : Form
    {
        private const int CP_DISABLE_CLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = cp.ClassStyle | CP_DISABLE_CLOSE_BUTTON;
                cp.ExStyle |= 0x80;  // Turn on WS_EX_TOOLWINDOW
                return cp;
            }
        }

        public Error3b()
        {
            InitializeComponent();
            
        }

        internal void AddPicture(Image img)
        {
            Image iOld = this.pictureBox1.Image;
            this.pictureBox1.Image = (Image)img.Clone();

            if (iOld != null)
                iOld.Dispose();
        }

        internal void SetLabel1(string txt1)
        {
            this.label1.Text = (string)txt1.Clone();
        }
        internal void SetLabel2(string txt2)
        {
            this.label2.Text = (string)txt2.Clone();
        }
        internal void SetLabel3(string txt3)
        {
            this.label3.Text = (string)txt3.Clone();
        }
        internal void SetLabel4(string txt4)
        {
            this.label4.Text = (string)txt4.Clone();
        }
        internal void SetTitle(string title)
        {
            this.Text = (string)title.Clone();
        }
        internal void BT0 (string BT0)
        {
            bool BT0b = Convert.ToBoolean((string)BT0.Clone());
            if (BT0b)
            {
                this.button1.Visible = false;
                this.button2.Visible = false;
                this.button3.Visible = false;
            }
        }
        internal void BT1(string BT1, string BT1Text, string BT1Iv)
        {
            bool BT1b = Convert.ToBoolean((string)BT1.Clone());
            bool BT1IV = Convert.ToBoolean((string)BT1Iv.Clone());
            if (BT1b)
            {
                this.button1.Visible = false;
                this.button2.Text = (string)BT1Text;
                this.button2.Visible = true;
                this.button2.Enabled = BT1IV;
                this.button3.Visible = false;
            }

        }
        internal void BT2(string BT2, string BT2Text1, string BT2Iv1, string BT2Text2, string BT2Iv2)
        {
            bool BT2b = Convert.ToBoolean((string)BT2.Clone());
            bool BT2IV1 = Convert.ToBoolean((string)BT2Iv1.Clone());
            bool BT2IV2 = Convert.ToBoolean((string)BT2Iv2.Clone());
            if (BT2b)
            {
                this.button1.Visible = true;
                this.button1.Text = (string)BT2Text2;
                this.button1.Location = new Point(222, 105);
                this.button1.Enabled = BT2IV2;
                this.button2.Visible = false;
                this.button3.Visible = true;
                this.button3.Text = (string)BT2Text1;
                this.button3.Location = new Point(60, 105);
                this.button3.Enabled = BT2IV1;
            }
        }
        internal void BT3(string BT3, string BT3Text1, string BT3Iv1, string BT3Text2, string BT3Iv2, string BT3Text3, string BT3Iv3)
        {
            bool BT3b = Convert.ToBoolean((string)BT3.Clone());
            bool BT3IV1 = Convert.ToBoolean((string)BT3Iv1.Clone());
            bool BT3IV2 = Convert.ToBoolean((string)BT3Iv2.Clone());
            bool BT3IV3 = Convert.ToBoolean((string)BT3Iv3.Clone());
            if (BT3b)
            {
                this.button1.Visible = true;
                this.button1.Text = (string)BT3Text3;
                this.button1.Enabled = BT3IV3;
                this.button2.Visible = true;
                this.button2.Text = (string)BT3Text2;
                this.button2.Enabled = BT3IV2;
                this.button3.Visible = true;
                this.button3.Text = (string)BT3Text1;
                this.button3.Enabled = BT3IV1;
            }

        }
    }
}

