using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanelTest2.UserControls
{
    public partial class CustomButton : UserControl
    {
        public CustomButton()
        {
            InitializeComponent();
        }

        public Image ActionImage
        {
            get { return actionImage.Image; }
            set { actionImage.Image = value; }
        }

        public string ActionName
        {
            get { return actionNameButton.Text; }
            set { actionNameButton.Text = value; }
        }

        private void actionImage_Click(object sender, EventArgs e)
        {
            actionNameButton_Click(sender, e);
        }

        private void actionNameButton_Click(object sender, EventArgs e)
        {

        }
    }
}
