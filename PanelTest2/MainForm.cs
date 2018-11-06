using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanelTest2
{
    public partial class MainForm : Form
    {
        bool _isFullscreeen = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void closeAppButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeAppButton_MouseHover(object sender, EventArgs e)
        {
            this.closeAppButton.BackColor = Color.Red;
        }

        private void closeAppButton_MouseLeave(object sender, EventArgs e)
        {
            this.closeAppButton.BackColor = Color.Transparent;
        }

        private void TitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void restoreWindowButton_Click(object sender, EventArgs e)
        {
            if (!_isFullscreeen)
            {
                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
                this.WindowState = FormWindowState.Maximized;
                _isFullscreeen = true;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                _isFullscreeen = false;
            }
        }

        private void hideWindowButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
