using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace osu_bm_dl
{
    public partial class setting : Form
    {
        bool first = false;
        string gameDir = Properties.Settings.Default.gameDir;
        public setting()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = Environment.GetEnvironmentVariable("username");

            FolderBrowserDialog gameFolder = new FolderBrowserDialog();
            gameFolder.SelectedPath = @"C:\Users\" + username + @"\AppData\Local\";
            if (gameFolder.ShowDialog() == DialogResult.OK)
            {
                selectGameFolder.Text = gameFolder.SelectedPath;
            }
            else
            {
                gameFolder.SelectedPath = @"";
            }

            if (first)
            {
                Properties.Settings.Default.gameDir = gameFolder.SelectedPath;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void setting_Load(object sender, EventArgs e)
        {
            if (gameDir.Length > 0)
            {
                selectGameFolder.Text = gameDir;
            }
            else first = true;
        }

        private void setting_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!(Properties.Settings.Default.gameDir.Length > 0))
            {
                MessageBox.Show("osu! Songs 폴더 경로를 설정해야 해요!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
            }
        }
    }
}
