using System.Windows.Forms;
using static WinFormsApp1.Form1;

namespace RTC
{
    public partial class FormRTC : Form
    {
        public FormRTC()
        {
            InitializeComponent();
            pictureBox1.Controls.Add(pictureBox4);
            pictureBox4.Location = new Point(15, 280);
            pictureBox4.BackColor = Color.Transparent;
        }

        private void Form_RTC_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();    
            int i = r.Next(0,32767);
            if (MyGlobals.prav == 1)
            {
                textBox1.Text = "32768Hz";
            }
            else
            {
                textBox1.Text = Convert.ToString(i) + "Hz";
            }
            pictureBox1.Controls.Add(pictureBox3);
            pictureBox3.Location = new Point(110, 49);
            pictureBox3.BackColor = Color.Transparent;
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
