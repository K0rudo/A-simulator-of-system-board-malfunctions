using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WinFormsApp1.Form1;

namespace WinFormsApp1
{
    public partial class Exit : Form
    {
        public Exit()
        {
            InitializeComponent();
            Bal.Text = MyGlobals.count.ToString();
        }
        private void Bal_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
