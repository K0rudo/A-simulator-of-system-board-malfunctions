using System.Windows.Forms;
using static WinFormsApp1.Form1;

namespace WinFormsApp2
{
    public partial class FormUSB1 : Form
    {
        public FormUSB1()
        {
            InitializeComponent();
            pictureBox1.Controls.Add(pictureBox4);
            pictureBox1.Controls.Add(pictureBox3);
            //SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            pictureBox3.BackColor = Color.Transparent;
            Random x = new Random();
            int v;
            for (int i = 0; i < 4; i++)
            {
                v = x.Next(450, 700);
                usb[i, 0] = v;
                usb[i, 1] = v + x.Next(0, 9);
            }
            if(MyGlobals.prav != 0)
            {
                v = x.Next(450, 600);
                int broke = x.Next(4);
                usb[broke, 0] = v;
                usb[broke, 1] = v + x.Next(100, 300);
            }

        }
        bool Flag = false;
        public void Mirror(bool Flag2)
        {
            if (Flag != Flag2)
            {
                Flag = Flag2;
                pictureBox3.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                pictureBox3.Refresh();
            }
        }
        int[,] usb = new int[4, 2];

        string plus = "415";
        string minus = "004";
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox3.Location = new Point(90, 200);
            Mirror(false);
            textBox1.Text = minus;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox3.Location = new Point(90, 185);
            Mirror(false);
            textBox1.Text = usb[0, 0].ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox3.Location = new Point(90, 170);
            Mirror(false);
            textBox1.Text = usb[0, 1].ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox3.Location = new Point(90, 155);
            Mirror(false);
            textBox1.Text = plus;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            pictureBox3.Location = new Point(90, 75);
            Mirror(false);
            textBox1.Text = minus;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            pictureBox3.Location = new Point(90, 60);
            Mirror(false);
            textBox1.Text = usb[2, 0].ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            pictureBox3.Location = new Point(90, 45);
            Mirror(false);
            textBox1.Text = usb[2, 1].ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            pictureBox3.Location = new Point(90, 30);
            Mirror(false);
            textBox1.Text = plus;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pictureBox3.Location = new Point(-70, 200);
            Mirror(true);
            textBox1.Text = minus;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox3.Location = new Point(-70, 185);
            Mirror(true);
            textBox1.Text = usb[1, 0].ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox3.Location = new Point(-70, 170);
            Mirror(true);
            textBox1.Text = usb[1, 1].ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox3.Location = new Point(-70, 155);
            Mirror(true);
            textBox1.Text = plus;
        }


        private void button12_Click(object sender, EventArgs e)
        {
            pictureBox3.Location = new Point(-70, 75);
            Mirror(true);
            textBox1.Text = minus;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            pictureBox3.Location = new Point(-70, 60);
            Mirror(true);
            textBox1.Text = usb[3, 0].ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pictureBox3.Location = new Point(-70, 45);
            Mirror(true);
            textBox1.Text = usb[3, 1].ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pictureBox3.Location = new Point(-70, 30);
            Mirror(true);
            textBox1.Text = plus;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
