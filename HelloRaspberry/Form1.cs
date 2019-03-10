using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloRaspberry
{
    public partial class frmHello : Form
    {
        private int nClick = 0;
        public frmHello()
        {
            InitializeComponent();
        }

        private void BtnClick_Click(object sender, EventArgs e)
        {
            RefreshText();
        }

        private void RefreshText()
        {
            nClick++;
            lblText.Text = $"I've been clicked {nClick} times";
        }

    }
}
