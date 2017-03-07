using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace TrollLauncher
{
    public partial class Form1 : Form
    {
        Error3b TrollForm = null;
        Notification not = new Notification();
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TrollForm == null || TrollForm.IsDisposed)
            TrollForm = new Error3b();
            TrollForm.Show();
            TrollForm.AddPicture(this.imgBox.Image);
            TrollForm.SetLabel1(this.txtLinha1.Text);
            TrollForm.SetLabel2(this.txtLinha2.Text);
            TrollForm.SetLabel3(this.txtLinha3.Text);
            TrollForm.SetLabel4(this.txtLinha4.Text);
            TrollForm.SetTitle(this.txtTitle.Text);
            string BT0C= "";
            if (this.radioBtn0.Checked == true) { BT0C = "true"; } else { BT0C = "false"; }
            TrollForm.BT0(BT0C);
            string BT1C = "", BT1V= "";
            if (this.radioBtn1.Checked == true) { BT1C = "true"; } else { BT1C = "false"; }
            if (this.checkBtn1Inativo.Checked == true) { BT1V = "false"; } else { BT1V = "true"; }
            TrollForm.BT1(BT1C, this.txtBtn1.Text, BT1V);
            string BT2C = "", BT2V = "";
            if (this.radioBtn2.Checked == true) { BT2C = "true"; } else { BT2C = "false"; }
            if (this.checkBtn2Inativo.Checked == true) { BT2V = "false"; } else { BT2V = "true"; }
            TrollForm.BT2(BT2C, this.txtBtn1.Text, BT1V, this.txtBtn2.Text, BT2V);
            string BT3C = "", BT3V = "";
            if (this.radioBtn3.Checked == true) { BT3C = "true"; } else { BT3C = "false"; }
            if (this.checkBtn3Inativo.Checked == true) { BT3V = "false"; } else { BT3V = "true"; }
            TrollForm.BT3(BT3C, this.txtBtn1.Text, BT1V, this.txtBtn2.Text, BT2V, this.txtBtn3.Text, BT3V);
            if (!not.checkBoxUsarPadrao.Checked)
            {
                if (not.labelLocal.Text != "...")
                {
                    Icon ico = Icon.ExtractAssociatedIcon(not.labelLocal.Text);
                    this.notifyIcon.Icon = ico;
                }
                this.notifyIcon.Text = not.textBoxTitulo.Text;
                this.toolStripMenuItem1.Text = not.textBoxBtnNome.Text;
            }
            this.notifyIcon.Visible = true;
            this.timerFocus.Start();
            this.Hide();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            imgBox.Image = (Image)Properties.Resources.ResourceManager.GetObject(listImg.Text);
            btnCriar.Enabled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtn0.Checked == true)
            {
                labelBtnTxt.Visible = false;
                labelBtnTxt1.Visible = false;
                labelBtnTxt2.Visible = false;
                labelBtnTxt3.Visible = false;
                txtBtn1.Visible = false;
                txtBtn2.Visible = false;
                txtBtn3.Visible = false;
                checkBtn1Inativo.Visible = false;
                checkBtn2Inativo.Visible = false;
                checkBtn3Inativo.Visible = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtn1.Checked == true)
            {
                labelBtnTxt.Visible = true;
                labelBtnTxt1.Visible = true;
                labelBtnTxt2.Visible = false;
                labelBtnTxt3.Visible = false;
                txtBtn1.Visible = true;
                txtBtn2.Visible = false;
                txtBtn3.Visible = false;
                checkBtn1Inativo.Visible = true;
                checkBtn2Inativo.Visible = false;
                checkBtn3Inativo.Visible = false;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtn2.Checked == true)
            {
                labelBtnTxt.Visible = true;
                labelBtnTxt1.Visible = true;
                labelBtnTxt2.Visible = true;
                labelBtnTxt3.Visible = false;
                txtBtn1.Visible = true;
                txtBtn2.Visible = true;
                txtBtn3.Visible = false;
                checkBtn1Inativo.Visible = true;
                checkBtn2Inativo.Visible = true;
                checkBtn3Inativo.Visible = false;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtn3.Checked == true)
            {
                labelBtnTxt.Visible = true;
                labelBtnTxt1.Visible = true;
                labelBtnTxt2.Visible = true;
                labelBtnTxt3.Visible = true;
                txtBtn1.Visible = true;
                txtBtn2.Visible = true;
                txtBtn3.Visible = true;
                checkBtn1Inativo.Visible = true;
                checkBtn2Inativo.Visible = true;
                checkBtn3Inativo.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.btnCriar.Enabled = true;
            this.imgBox.Image = Properties.Resources.Error;
            this.txtTitle.Text = "Oh shit!!";
            this.txtLinha1.Text = "No more disk space.";
            this.txtLinha2.Text = "";
            this.txtLinha3.Text = "Delete Windows?";
            this.txtLinha4.Text = "";
            this.txtBtn1.Text = "Yes"; this.checkBtn1Inativo.Checked = false;
            this.txtBtn2.Text = ""; this.checkBtn2Inativo.Checked = false;
            this.txtBtn3.Text = ""; this.checkBtn3Inativo.Checked = false;
            this.radioBtn1.Checked = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.txtLinha1.Text = "";
            this.txtLinha2.Text = "";
            this.txtLinha3.Text = "";
            this.txtLinha4.Text = "";
            this.txtBtn1.Text = "";
            this.txtBtn2.Text = "";
            this.txtBtn3.Text = "";
            this.txtTitle.Text = "";
            this.checkBtn1Inativo.Checked = false;
            this.checkBtn2Inativo.Checked = false;
            this.checkBtn3Inativo.Checked = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.btnCriar.Enabled = true;
            this.imgBox.Image = Properties.Resources.bomb;
            this.txtTitle.Text = "Run Error";
            this.txtLinha1.Text = "Run as fast as you can and don't look back.";
            this.txtLinha2.Text = "";
            this.txtLinha3.Text = "";
            this.txtLinha4.Text = "";
            this.txtBtn1.Text = "OK"; this.checkBtn1Inativo.Checked = false;
            this.txtBtn2.Text = ""; this.checkBtn2Inativo.Checked = false;
            this.txtBtn3.Text = ""; this.checkBtn3Inativo.Checked = false;
            this.radioBtn1.Checked = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.btnCriar.Enabled = true;
            this.imgBox.Image = Properties.Resources.mail_deleted;
            this.txtTitle.Text = "Error";
            this.txtLinha1.Text = "No more space on disk.";
            this.txtLinha2.Text = "";
            this.txtLinha3.Text = "Delete mail folder?";
            this.txtLinha4.Text = "";
            this.txtBtn1.Text = "Cancel"; this.checkBtn1Inativo.Checked = true;
            this.txtBtn2.Text = "OK"; this.checkBtn2Inativo.Checked = false;
            this.txtBtn3.Text = ""; this.checkBtn3Inativo.Checked = false;
            this.radioBtn2.Checked = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.btnCriar.Enabled = true;
            this.imgBox.Image = Properties.Resources.hammer;
            this.txtTitle.Text = "Hardware error";
            this.txtLinha1.Text = "Windows will now smash your C:/ drive with a hammer.";
            this.txtLinha2.Text = "";
            this.txtLinha3.Text = "";
            this.txtLinha4.Text = "";
            this.txtBtn1.Text = "Cancel"; this.checkBtn1Inativo.Checked = true;
            this.txtBtn2.Text = "OK"; this.checkBtn2Inativo.Checked = false;
            this.txtBtn3.Text = "Details"; this.checkBtn3Inativo.Checked = false;
            this.radioBtn3.Checked = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.btnCriar.Enabled = true;
            this.imgBox.Image = Properties.Resources.Error3;
            this.txtTitle.Text = "Warning";
            this.txtLinha1.Text = "Proceeding with the operation 'Delete' will";
            this.txtLinha2.Text = "erase the contents of your hard drive.";
            this.txtLinha3.Text = "What do you wish to do?";
            this.txtLinha4.Text = "";
            this.txtBtn1.Text = "Proceed"; this.checkBtn1Inativo.Checked = false;
            this.txtBtn2.Text = "Delete"; this.checkBtn2Inativo.Checked = false;
            this.txtBtn3.Text = ""; this.checkBtn3Inativo.Checked = false;
            this.radioBtn2.Checked = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.btnCriar.Enabled = true;
            this.imgBox.Image = Properties.Resources.Attention;
            this.txtTitle.Text = "Windows error";
            this.txtLinha1.Text = "";
            this.txtLinha2.Text = "Click 'OK' to continue.";
            this.txtLinha3.Text = "";
            this.txtLinha4.Text = "";
            this.txtBtn1.Text = "OK"; this.checkBtn1Inativo.Checked = true;
            this.txtBtn2.Text = ""; this.checkBtn2Inativo.Checked = false;
            this.txtBtn3.Text = ""; this.checkBtn3Inativo.Checked = false;
            this.radioBtn1.Checked = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.btnCriar.Enabled = true;
            this.imgBox.Image = Properties.Resources.Error3;
            this.txtTitle.Text = "Something went wrong";
            this.txtLinha1.Text = "Windows will now delete all";
            this.txtLinha2.Text = "files from your hard drive.";
            this.txtLinha3.Text = "";
            this.txtLinha4.Text = "";
            this.txtBtn1.Text = "Cancel"; this.checkBtn1Inativo.Checked = true;
            this.txtBtn2.Text = "OK"; this.checkBtn2Inativo.Checked = false;
            this.txtBtn3.Text = ""; this.checkBtn3Inativo.Checked = false;
            this.radioBtn2.Checked = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.btnCriar.Enabled = true;
            this.imgBox.Image = Properties.Resources.setup;
            this.txtTitle.Text = "Windows Hardware Update";
            this.txtLinha1.Text = "Windows has detected that you have moved your mouse.";
            this.txtLinha2.Text = "Please restart your computer.";
            this.txtLinha3.Text = "";
            this.txtLinha4.Text = "";
            this.txtBtn1.Text = "Cancel"; this.checkBtn1Inativo.Checked = true;
            this.txtBtn2.Text = "Restart"; this.checkBtn2Inativo.Checked = false;
            this.txtBtn3.Text = ""; this.checkBtn3Inativo.Checked = false;
            this.radioBtn2.Checked = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.btnCriar.Enabled = true;
            this.imgBox.Image = Properties.Resources.butterfly;
            this.txtTitle.Text = "Bug found";
            this.txtLinha1.Text = "Windows found a bug in your software. It's";
            this.txtLinha2.Text = "a fucking butterfly.";
            this.txtLinha3.Text = "";
            this.txtLinha4.Text = "";
            this.txtBtn1.Text = "OK"; this.checkBtn1Inativo.Checked = false;
            this.txtBtn2.Text = "Ignore"; this.checkBtn2Inativo.Checked = false;
            this.txtBtn3.Text = ""; this.checkBtn3Inativo.Checked = false;
            this.radioBtn2.Checked = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.btnCriar.Enabled = true;
            this.imgBox.Image = Properties.Resources.disk_skull;
            this.txtTitle.Text = "Windows VirusScan 1.0";
            this.txtLinha1.Text = "Found infected file:\"Microsoft Windows\"";
            this.txtLinha2.Text = "";
            this.txtLinha3.Text = "Remove it?";
            this.txtLinha4.Text = "";
            this.txtBtn1.Text = "Yes"; this.checkBtn1Inativo.Checked = false;
            this.txtBtn2.Text = "No"; this.checkBtn2Inativo.Checked = false;
            this.txtBtn3.Text = ""; this.checkBtn3Inativo.Checked = false;
            this.radioBtn2.Checked = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.btnCriar.Enabled = true;
            this.imgBox.Image = Properties.Resources.Attention;
            this.txtTitle.Text = "Keyboard Error";
            this.txtLinha1.Text = "Keyboard not responding. Press any key to continue.";
            this.txtLinha2.Text = "";
            this.txtLinha3.Text = "";
            this.txtLinha4.Text = "";
            this.txtBtn1.Text = ""; this.checkBtn1Inativo.Checked = false;
            this.txtBtn2.Text = ""; this.checkBtn2Inativo.Checked = false;
            this.txtBtn3.Text = ""; this.checkBtn3Inativo.Checked = false;
            this.radioBtn0.Checked = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.btnCriar.Enabled = true;
            this.imgBox.Image = Properties.Resources.tux;
            this.txtTitle.Text = "Windoze Error";
            this.txtLinha1.Text = "Please insert a Linux installation CD and reboot";
            this.txtLinha2.Text = "";
            this.txtLinha3.Text = "";
            this.txtLinha4.Text = "";
            this.txtBtn1.Text = "Reboot"; this.checkBtn1Inativo.Checked = false;
            this.txtBtn2.Text = ""; this.checkBtn2Inativo.Checked = false;
            this.txtBtn3.Text = ""; this.checkBtn3Inativo.Checked = false;
            this.radioBtn1.Checked = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.btnCriar.Enabled = true;
            this.imgBox.Image = Properties.Resources.tux_config;
            this.txtTitle.Text = "System Error";
            this.txtLinha1.Text = "Your operating system \"Windows 7\" is broken.";
            this.txtLinha2.Text = "";
            this.txtLinha3.Text = "Please select a new operating system and upgrade.";
            this.txtLinha4.Text = "";
            this.txtBtn1.Text = "Linux"; this.checkBtn1Inativo.Checked = false;
            this.txtBtn2.Text = "FreeBSD"; this.checkBtn2Inativo.Checked = false;
            this.txtBtn3.Text = "Mac OS-X"; this.checkBtn3Inativo.Checked = false;
            this.radioBtn3.Checked = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.btnCriar.Enabled = true;
            this.imgBox.Image = Properties.Resources.defrag;
            this.txtTitle.Text = "C:/ Decompiling";
            this.txtLinha1.Text = "Windows has found an error on your C:/";
            this.txtLinha2.Text = "drive and is now deleting its contents";
            this.txtLinha3.Text = "in order to repair the error.";
            this.txtLinha4.Text = "";
            this.txtBtn1.Text = "Cancel"; this.checkBtn1Inativo.Checked = true;
            this.txtBtn2.Text = "Details"; this.checkBtn2Inativo.Checked = false;
            this.txtBtn3.Text = ""; this.checkBtn3Inativo.Checked = false;
            this.radioBtn2.Checked = true;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Sobre sobre = new Sobre();
            sobre.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TrollForm.Activate();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            not.Show();
        }

    }
}
