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
    public partial class Form1 : Form
    {
        Error3b Form2 = null;
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Form2 == null || Form2.IsDisposed)
            Form2 = new Error3b();
            Form2.Show();
            Form2.AddPicture(this.pictureBox1.Image);
            Form2.SetLabel1(this.textBox1.Text);
            Form2.SetLabel2(this.textBox2.Text);
            Form2.SetLabel3(this.textBox3.Text);
            Form2.SetLabel4(this.textBox4.Text);
            Form2.SetTitle(this.textBox8.Text);
            string BT0C= "";
            if (this.radioButton1.Checked == true) { BT0C = "true"; } else { BT0C = "false"; }
            Form2.BT0(BT0C);
            string BT1C = "", BT1V= "";
            if (this.radioButton2.Checked == true) { BT1C = "true"; } else { BT1C = "false"; }
            if (this.checkBox1.Checked == true) { BT1V = "false"; } else { BT1V = "true"; }
            Form2.BT1(BT1C, this.textBox5.Text, BT1V);
            string BT2C = "", BT2V = "";
            if (this.radioButton3.Checked == true) { BT2C = "true"; } else { BT2C = "false"; }
            if (this.checkBox2.Checked == true) { BT2V = "false"; } else { BT2V = "true"; }
            Form2.BT2(BT2C, this.textBox5.Text, BT1V, this.textBox6.Text, BT2V);
            string BT3C = "", BT3V = "";
            if (this.radioButton4.Checked == true) { BT3C = "true"; } else { BT3C = "false"; }
            if (this.checkBox3.Checked == true) { BT3V = "false"; } else { BT3V = "true"; }
            Form2.BT3(BT3C, this.textBox5.Text, BT1V, this.textBox6.Text, BT2V, this.textBox7.Text, BT3V);
            this.notifyIcon1.Visible = true;

            this.Hide();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {

            if (listBox1.Text == "aim_guy")
            {
                pictureBox1.Image = Properties.Resources.aim_guy;
            }
            if (listBox1.Text == "aol_icon")
            {
                pictureBox1.Image = Properties.Resources.aol_icon;
            }
            if (listBox1.Text == "Attention")
            {
                pictureBox1.Image = Properties.Resources.Attention;
            }
            if (listBox1.Text == "bomb")
            {
                pictureBox1.Image = Properties.Resources.bomb;
            }
            if (listBox1.Text == "bomb_dynamite")
            {
                pictureBox1.Image = Properties.Resources.bomb_dynamite;
            }
            if (listBox1.Text == "bomb_grenade")
            {
                pictureBox1.Image = Properties.Resources.bomb_grenade;
            }
            if (listBox1.Text == "bubble_i")
            {
                pictureBox1.Image = Properties.Resources.bubble_i;
            }
            if (listBox1.Text == "bubble_q")
            {
                pictureBox1.Image = Properties.Resources.bubble_q;
            }
            if (listBox1.Text == "aol_icon")
            {
                pictureBox1.Image = Properties.Resources.aol_icon;
            }
            if (listBox1.Text == "bulb")
            {
                pictureBox1.Image = Properties.Resources.bulb;
            }
            if (listBox1.Text == "butterfly")
            {
                pictureBox1.Image = Properties.Resources.butterfly;
            }
            if (listBox1.Text == "cake")
            {
                pictureBox1.Image = Properties.Resources.cake;
            }
            if (listBox1.Text == "circularsaw")
            {
                pictureBox1.Image = Properties.Resources.circularsaw;
            }
            if (listBox1.Text == "control_panel")
            {
                pictureBox1.Image = Properties.Resources.control_panel;
            }
            if (listBox1.Text == "cow")
            {
                pictureBox1.Image = Properties.Resources.cow;
            }
            if (listBox1.Text == "defrag")
            {
                pictureBox1.Image = Properties.Resources.defrag;
            }
            if (listBox1.Text == "disk_blu")
            {
                pictureBox1.Image = Properties.Resources.disk_blu;
            }
            if (listBox1.Text == "disk_blu_lbl")
            {
                pictureBox1.Image = Properties.Resources.disk_blu_lbl;
            }
            if (listBox1.Text == "disk_org")
            {
                pictureBox1.Image = Properties.Resources.disk_org;
            }
            if (listBox1.Text == "disk_red")
            {
                pictureBox1.Image = Properties.Resources.disk_red;
            }
            if (listBox1.Text == "disk_red_lbl")
            {
                pictureBox1.Image = Properties.Resources.disk_red_lbl;
            }
            if (listBox1.Text == "disk_skull")
            {
                pictureBox1.Image = Properties.Resources.disk_skull;
            }
            if (listBox1.Text == "disk_yel")
            {
                pictureBox1.Image = Properties.Resources.disk_yel;
            }
            if (listBox1.Text == "dos")
            {
                pictureBox1.Image = Properties.Resources.dos;
            }
            if (listBox1.Text == "e_orbit")
            {
                pictureBox1.Image = Properties.Resources.e_orbit;
            }
            if (listBox1.Text == "Error")
            {
                pictureBox1.Image = Properties.Resources.Error;
            }
            if (listBox1.Text == "Error2")
            {
                pictureBox1.Image = Properties.Resources.Error2;
            }
            if (listBox1.Text == "Error3")
            {
                pictureBox1.Image = Properties.Resources.Error3;
            }
            if (listBox1.Text == "Error4")
            {
                pictureBox1.Image = Properties.Resources.Error4;
            }
            if (listBox1.Text == "file_cabinet")
            {
                pictureBox1.Image = Properties.Resources.file_cabinet;
            }
            if (listBox1.Text == "find")
            {
                pictureBox1.Image = Properties.Resources.find;
            }
            if (listBox1.Text == "fortunecookie")
            {
                pictureBox1.Image = Properties.Resources.fortunecookie;
            }
            if (listBox1.Text == "garbage_empty")
            {
                pictureBox1.Image = Properties.Resources.garbage_empty;
            }
            if (listBox1.Text == "garbage_full")
            {
                pictureBox1.Image = Properties.Resources.garbage_full;
            }
            if (listBox1.Text == "gun")
            {
                pictureBox1.Image = Properties.Resources.gun;
            }
            if (listBox1.Text == "hammer")
            {
                pictureBox1.Image = Properties.Resources.hammer;
            }
            if (listBox1.Text == "heart")
            {
                pictureBox1.Image = Properties.Resources.heart;
            }
            if (listBox1.Text == "help")
            {
                pictureBox1.Image = Properties.Resources.help;
            }
            if (listBox1.Text == "hub")
            {
                pictureBox1.Image = Properties.Resources.hub;
            }
            if (listBox1.Text == "hwinfo")
            {
                pictureBox1.Image = Properties.Resources.hwinfo;
            }
            if (listBox1.Text == "ic_a")
            {
                pictureBox1.Image = Properties.Resources.ic_a;
            }
            if (listBox1.Text == "keys")
            {
                pictureBox1.Image = Properties.Resources.keys;
            }
            if (listBox1.Text == "keys2")
            {
                pictureBox1.Image = Properties.Resources.keys2;
            }
            if (listBox1.Text == "keys3")
            {
                pictureBox1.Image = Properties.Resources.keys3;
            }
            if (listBox1.Text == "labtec")
            {
                pictureBox1.Image = Properties.Resources.labtec;
            }
            if (listBox1.Text == "mac")
            {
                pictureBox1.Image = Properties.Resources.mac;
            }
            if (listBox1.Text == "mail")
            {
                pictureBox1.Image = Properties.Resources.mail;
            }
            if (listBox1.Text == "mail_deleted")
            {
                pictureBox1.Image = Properties.Resources.mail_deleted;
            }
            if (listBox1.Text == "mailbox")
            {
                pictureBox1.Image = Properties.Resources.mailbox;
            }
            if (listBox1.Text == "mouth")
            {
                pictureBox1.Image = Properties.Resources.mouth;
            }
            if (listBox1.Text == "mycomputer")
            {
                pictureBox1.Image = Properties.Resources.mycomputer;
            }
            if (listBox1.Text == "mycomputer2")
            {
                pictureBox1.Image = Properties.Resources.mycomputer2;
            }
            if (listBox1.Text == "mycomputer3")
            {
                pictureBox1.Image = Properties.Resources.mycomputer3;
            }
            if (listBox1.Text == "newspaper")
            {
                pictureBox1.Image = Properties.Resources.newspaper;
            }
            if (listBox1.Text == "peripheral")
            {
                pictureBox1.Image = Properties.Resources.peripheral;
            }
            if (listBox1.Text == "plant_leaf")
            {
                pictureBox1.Image = Properties.Resources.plant_leaf;
            }
            if (listBox1.Text == "radiation")
            {
                pictureBox1.Image = Properties.Resources.radiation;
            }
            if (listBox1.Text == "ram")
            {
                pictureBox1.Image = Properties.Resources.ram;
            }
            if (listBox1.Text == "recycle")
            {
                pictureBox1.Image = Properties.Resources.recycle;
            }
            if (listBox1.Text == "recycle2")
            {
                pictureBox1.Image = Properties.Resources.recycle2;
            }
            if (listBox1.Text == "scanner")
            {
                pictureBox1.Image = Properties.Resources.scanner;
            }
            if (listBox1.Text == "screw")
            {
                pictureBox1.Image = Properties.Resources.screw;
            }
            if (listBox1.Text == "screw2")
            {
                pictureBox1.Image = Properties.Resources.screw2;
            }
            if (listBox1.Text == "setup")
            {
                pictureBox1.Image = Properties.Resources.setup;
            }
            if (listBox1.Text == "sknife")
            {
                pictureBox1.Image = Properties.Resources.sknife;
            }
            if (listBox1.Text == "skull")
            {
                pictureBox1.Image = Properties.Resources.skull;
            }
            if (listBox1.Text == "skull2")
            {
                pictureBox1.Image = Properties.Resources.skull2;
            }
            if (listBox1.Text == "skull3")
            {
                pictureBox1.Image = Properties.Resources.skull3;
            }
            if (listBox1.Text == "tux")
            {
                pictureBox1.Image = Properties.Resources.tux;
            }
            if (listBox1.Text == "tux_config")
            {
                pictureBox1.Image = Properties.Resources.tux_config;
            }
            if (listBox1.Text == "ups")
            {
                pictureBox1.Image = Properties.Resources.ups;
            }
            if (listBox1.Text == "zipdisk")
            {
                pictureBox1.Image = Properties.Resources.zipdisk;
            }
            if (listBox1.Text == "zipdisks")
            {
                pictureBox1.Image = Properties.Resources.zipdisks;
            }
            button1.Enabled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                textBox7.Visible = false;
                checkBox1.Visible = false;
                checkBox2.Visible = false;
                checkBox3.Visible = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = false;
                label8.Visible = false;
                textBox5.Visible = true;
                textBox6.Visible = false;
                textBox7.Visible = false;
                checkBox1.Visible = true;
                checkBox2.Visible = false;
                checkBox3.Visible = false;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = false;
                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = false;
                checkBox1.Visible = true;
                checkBox2.Visible = true;
                checkBox3.Visible = false;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = true;
                checkBox1.Visible = true;
                checkBox2.Visible = true;
                checkBox3.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.button1.Enabled = true;
            this.pictureBox1.Image = Properties.Resources.Error;
            this.textBox8.Text = "Oh shit!!";
            this.textBox1.Text = "No more disk space.";
            this.textBox2.Text = "";
            this.textBox3.Text = "Delete Windows?";
            this.textBox4.Text = "";
            this.textBox5.Text = "Yes"; this.checkBox1.Checked = false;
            this.textBox6.Text = ""; this.checkBox2.Checked = false;
            this.textBox7.Text = ""; this.checkBox3.Checked = false;
            this.radioButton2.Checked = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            this.textBox5.Text = "";
            this.textBox6.Text = "";
            this.textBox7.Text = "";
            this.textBox8.Text = "";
            this.checkBox1.Checked = false;
            this.checkBox2.Checked = false;
            this.checkBox3.Checked = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.button1.Enabled = true;
            this.pictureBox1.Image = Properties.Resources.bomb;
            this.textBox8.Text = "Run Error";
            this.textBox1.Text = "Run as fast as you can and don't look back.";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            this.textBox5.Text = "OK"; this.checkBox1.Checked = false;
            this.textBox6.Text = ""; this.checkBox2.Checked = false;
            this.textBox7.Text = ""; this.checkBox3.Checked = false;
            this.radioButton2.Checked = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.button1.Enabled = true;
            this.pictureBox1.Image = Properties.Resources.mail_deleted;
            this.textBox8.Text = "Error";
            this.textBox1.Text = "No more space on disk.";
            this.textBox2.Text = "";
            this.textBox3.Text = "Delete mail folder?";
            this.textBox4.Text = "";
            this.textBox5.Text = "Cancel"; this.checkBox1.Checked = true;
            this.textBox6.Text = "OK"; this.checkBox2.Checked = false;
            this.textBox7.Text = ""; this.checkBox3.Checked = false;
            this.radioButton3.Checked = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.button1.Enabled = true;
            this.pictureBox1.Image = Properties.Resources.hammer;
            this.textBox8.Text = "Hardware error";
            this.textBox1.Text = "Windows will now smash your C:/ drive with a hammer.";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            this.textBox5.Text = "Cancel"; this.checkBox1.Checked = true;
            this.textBox6.Text = "OK"; this.checkBox2.Checked = false;
            this.textBox7.Text = "Details"; this.checkBox3.Checked = false;
            this.radioButton4.Checked = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.button1.Enabled = true;
            this.pictureBox1.Image = Properties.Resources.Error3;
            this.textBox8.Text = "Warning";
            this.textBox1.Text = "Proceeding with the operation 'Delete' will";
            this.textBox2.Text = "erase the contents of your hard drive.";
            this.textBox3.Text = "What do you wish to do?";
            this.textBox4.Text = "";
            this.textBox5.Text = "Proceed"; this.checkBox1.Checked = false;
            this.textBox6.Text = "Delete"; this.checkBox2.Checked = false;
            this.textBox7.Text = ""; this.checkBox3.Checked = false;
            this.radioButton3.Checked = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.button1.Enabled = true;
            this.pictureBox1.Image = Properties.Resources.Attention;
            this.textBox8.Text = "Windows error";
            this.textBox1.Text = "";
            this.textBox2.Text = "Click 'OK' to continue.";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            this.textBox5.Text = "OK"; this.checkBox1.Checked = true;
            this.textBox6.Text = ""; this.checkBox2.Checked = false;
            this.textBox7.Text = ""; this.checkBox3.Checked = false;
            this.radioButton2.Checked = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.button1.Enabled = true;
            this.pictureBox1.Image = Properties.Resources.Error3;
            this.textBox8.Text = "Something went wrong";
            this.textBox1.Text = "Windows will now delete all";
            this.textBox2.Text = "files from your hard drive.";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            this.textBox5.Text = "Cancel"; this.checkBox1.Checked = true;
            this.textBox6.Text = "OK"; this.checkBox2.Checked = false;
            this.textBox7.Text = ""; this.checkBox3.Checked = false;
            this.radioButton3.Checked = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.button1.Enabled = true;
            this.pictureBox1.Image = Properties.Resources.setup;
            this.textBox8.Text = "Windows Hardware Update";
            this.textBox1.Text = "Windows has detected that you have moved your mouse.";
            this.textBox2.Text = "Please restart your computer.";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            this.textBox5.Text = "Cancel"; this.checkBox1.Checked = true;
            this.textBox6.Text = "Restart"; this.checkBox2.Checked = false;
            this.textBox7.Text = ""; this.checkBox3.Checked = false;
            this.radioButton3.Checked = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.button1.Enabled = true;
            this.pictureBox1.Image = Properties.Resources.butterfly;
            this.textBox8.Text = "Bug found";
            this.textBox1.Text = "Windows found a bug in your software. It's";
            this.textBox2.Text = "a fucking butterfly.";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            this.textBox5.Text = "OK"; this.checkBox1.Checked = false;
            this.textBox6.Text = "Ignore"; this.checkBox2.Checked = false;
            this.textBox7.Text = ""; this.checkBox3.Checked = false;
            this.radioButton3.Checked = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.button1.Enabled = true;
            this.pictureBox1.Image = Properties.Resources.disk_skull;
            this.textBox8.Text = "Windows VirusScan 1.0";
            this.textBox1.Text = "Found infected file:\"Microsoft Windows\"";
            this.textBox2.Text = "";
            this.textBox3.Text = "Remove it?";
            this.textBox4.Text = "";
            this.textBox5.Text = "Yes"; this.checkBox1.Checked = false;
            this.textBox6.Text = "No"; this.checkBox2.Checked = false;
            this.textBox7.Text = ""; this.checkBox3.Checked = false;
            this.radioButton3.Checked = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.button1.Enabled = true;
            this.pictureBox1.Image = Properties.Resources.Attention;
            this.textBox8.Text = "Keyboard Error";
            this.textBox1.Text = "Keyboard not responding. Press any key to continue.";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            this.textBox5.Text = ""; this.checkBox1.Checked = false;
            this.textBox6.Text = ""; this.checkBox2.Checked = false;
            this.textBox7.Text = ""; this.checkBox3.Checked = false;
            this.radioButton1.Checked = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.button1.Enabled = true;
            this.pictureBox1.Image = Properties.Resources.tux;
            this.textBox8.Text = "Windoze Error";
            this.textBox1.Text = "Please insert a Linux installation CD and reboot";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            this.textBox5.Text = "Reboot"; this.checkBox1.Checked = false;
            this.textBox6.Text = ""; this.checkBox2.Checked = false;
            this.textBox7.Text = ""; this.checkBox3.Checked = false;
            this.radioButton2.Checked = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.button1.Enabled = true;
            this.pictureBox1.Image = Properties.Resources.tux_config;
            this.textBox8.Text = "System Error";
            this.textBox1.Text = "Your operating system \"Windows 7\" is broken.";
            this.textBox2.Text = "";
            this.textBox3.Text = "Please select a new operating system and upgrade.";
            this.textBox4.Text = "";
            this.textBox5.Text = "Linux"; this.checkBox1.Checked = false;
            this.textBox6.Text = "FreeBSD"; this.checkBox2.Checked = false;
            this.textBox7.Text = "Mac OS-X"; this.checkBox3.Checked = false;
            this.radioButton4.Checked = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.button1.Enabled = true;
            this.pictureBox1.Image = Properties.Resources.defrag;
            this.textBox8.Text = "C:/ Decompiling";
            this.textBox1.Text = "Windows has found an error on your C:/";
            this.textBox2.Text = "drive and is now deleting its contents";
            this.textBox3.Text = "in order to repair the error.";
            this.textBox4.Text = "";
            this.textBox5.Text = "Cancel"; this.checkBox1.Checked = true;
            this.textBox6.Text = "Details"; this.checkBox2.Checked = false;
            this.textBox7.Text = ""; this.checkBox3.Checked = false;
            this.radioButton3.Checked = true;
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
    }
}
