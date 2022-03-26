using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EZCorsshair
{
    public partial class Form1 : Form
    {
        static Form RedDot;
        private static bool crosshair_enabled = false;
        private static Color crosshaircolor = new Color();
        private static bool medium;
        private static bool small;
        private static bool big;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_draw_Click(object sender, EventArgs e)
        {
            RedDot_crosshair();
            crosshair_enabled = true;
        }

        //Creates the crosshair as a form
        [STAThread]
        public static void RedDot_crosshair()
        {
            
            if (crosshair_enabled == false)
            {
                RedDot = new Form();
                RedDot.AutoSize = false;
                RedDot.BackColor = crosshaircolor;
                RedDot.FormBorderStyle = FormBorderStyle.None;
                RedDot.ShowInTaskbar = false;
                RedDot.Size = new Size(5, 5);
                RedDot.StartPosition = FormStartPosition.CenterScreen;
                RedDot.TopMost = true;
                RedDot.Shown += new EventHandler(RedDot_Shown);
                RedDot.Text = "Crosshair";
                RedDot.Show();
            }
            else if (crosshair_enabled == true)
            {
                MessageBox.Show("The crosshair is already drawn!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        //This handles the size off the crosshair that was chosen in the combobox_size
        private static void RedDot_Shown(object sender, EventArgs e)
        {
            if(big)
            {
                RedDot.Size = new Size(10,10);
            }
            else if(medium)
            {
                RedDot.Size = new Size(5, 5);
            }
            else if(small)
            {
                RedDot.Size = new Size(2, 2);
            }
        }

        private void button_hide_Click(object sender, EventArgs e)
        {
            hideCrosshair();
            crosshair_enabled = false;
        }

        //Closes the crosshair when the app closes to prevent it running in the background
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            closeallCrosshairs();
        }

        private void closeallCrosshairs()
        {
            if(crosshair_enabled == false)
            {
                return;
            }
            else
            {
                RedDot.Close();
            }
        }

        private void hideCrosshair()
        {
            RedDot.Hide();
        }

        private void comboBox_color_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(crosshair_enabled)
            {
                MessageBox.Show("Cant change color while the crosshair is running!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                switch (comboBox_color.SelectedIndex)
                {
                    case 0:
                        crosshaircolor = Color.Red;
                        break;
                    case 1:
                        crosshaircolor = Color.Purple;
                        break;
                    case 2:
                        crosshaircolor = Color.LimeGreen;
                        break;
                    case 3:
                        crosshaircolor = Color.Blue;
                        break;
                    case 4:
                        crosshaircolor = Color.White;
                        break;
                    case 5:
                        crosshaircolor = Color.Black;
                        break;
                }
            }            
        }

        private void comboBox_color_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox_size_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(crosshair_enabled)
            {
                MessageBox.Show("Cant change size while the crosshair is running!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                switch (comboBox_size.SelectedIndex)
                {
                    case 0:
                        small = true;
                        big = false;
                        medium = false;
                        break;
                    case 1:
                        medium = true;
                        small = false;
                        big = false;
                        break;
                    case 2:
                        big = true;
                        medium = false;
                        small = false;
                        break;
                }
            }
        }

        //Sets the default size and color which i find the best personally
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_size.SelectedIndex = 1;
            comboBox_color.SelectedIndex = 2;
        }

        private void linkLabel_github_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/Glumboi");
        }

        private void linkLabel_version_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/Glumboi/EZCorsshair");
        }
    }
}
