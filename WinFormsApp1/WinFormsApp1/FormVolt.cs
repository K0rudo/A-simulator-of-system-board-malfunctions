using static WinFormsApp1.Form1;

namespace Power_lines
{
    public partial class FormVolt : Form
    {

        public FormVolt()
        {
            InitializeComponent();
            pictureBox1.Controls.Add(pictureBox3);
            pictureBox3.Location = new Point(170, 370);
            pictureBox3.BackColor = Color.Transparent;
            pictureBox1.Controls.Add(pictureBox4);
            pictureBox4.Location = new Point(120, 30);
            pictureBox4.BackColor = Color.Transparent;
            Trans(button1);
            Trans(button2);
            Trans(button4);
            Trans(button5);
            Trans(button6);
            Trans(button7);
            Trans(button8);
            Trans(button9);
            Trans(button10);
            Trans(button11);
            Trans(button12);
            Random x = new Random();
            int v;
            if (MyGlobals.prav == 2)
            {
                for (int i = 0; i < 4; i++)
                {
                    v = x.Next(500, 600);
                    threeV[i] = v;
                }

                for (int i = 0; i < 5; i++)
                {
                    v = x.Next(700, 800);
                    fiveV[i] = v;
                }

                for (int i = 0; i < 2; i++)
                {
                    v = x.Next(1000, 1100);
                    twelveV[i] = v;

                }
            }
            Random r = new Random();   

            if (MyGlobals.volt == 0)
            {
                int p = r.Next(0, 3);

                for (int i = 0; i < 4; i++)
                {
                    v = x.Next(500, 600);
                    threeV[i] = v;
                }

                for (int i = 0; i < 5; i++)
                {
                    v = x.Next(700, 800);
                    fiveV[i] = v;
                }

                for (int i = 0; i < 2; i++)
                {
                    v = x.Next(1000, 1100);
                    twelveV[i] = v;

                }
                threeV[p] = 10;
            }
            if (MyGlobals.volt == 1)
            {
                int p = r.Next(0, 4);

                for (int i = 0; i < 4; i++)
                {
                    v = x.Next(500, 600);
                    threeV[i] = v;
                }

                for (int i = 0; i < 5; i++)
                {
                    v = x.Next(700, 800);
                    fiveV[i] = v;
                }

                for (int i = 0; i < 2; i++)
                {
                    v = x.Next(1000, 1100);
                    twelveV[i] = v;

                }
                fiveV[p] = 10;
            }
            if (MyGlobals.volt == 2)
            {
                int p = r.Next(0,1);

                for (int i = 0; i < 4; i++)
                {
                    v = x.Next(500, 600);
                    threeV[i] = v;
                }

                for (int i = 0; i < 5; i++)
                {
                    v = x.Next(700, 800);
                    fiveV[i] = v;
                }

                for (int i = 0; i < 2; i++)
                {
                    v = x.Next(1000, 1100);
                    twelveV[i] = v;

                }
                twelveV[p] = 10;
            }
        }
        public void Trans(Button but)
        {
            but.BackColor = Color.Transparent;
            but.FlatStyle = FlatStyle.Flat;
            but.FlatAppearance.BorderSize = 0;
            but.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, 52, 152, 219);
            but.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 52, 152, 219);
            pictureBox1.Controls.Add(but);//добавляем кнопку в кортинку и она становится прозрачной относительно картинки
        }

        bool Flag = false;
        public void Mirror(bool Flag2)
        {
            if (Flag != Flag2)
            {
                Flag = Flag2;
                pictureBox4.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                pictureBox4.Refresh();
            }
        }

        int[] threeV = new int[4];
        int[] fiveV = new int[5];
        int[] twelveV = new int[2];
        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mirror(true);
            pictureBox4.Location = new Point(10, 95);
            textBox1.Text = threeV[0].ToString();

        }


        private void button2_Click(object sender, EventArgs e)
        {
            Mirror(true);
            pictureBox4.Location = new Point(10, 120);
            textBox1.Text = threeV[1].ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Mirror(true);
            pictureBox4.Location = new Point(10, 195);
            textBox1.Text = fiveV[0].ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Mirror(true);
            pictureBox4.Location = new Point(10, 245);
            textBox1.Text = fiveV[1].ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Mirror(true);
            pictureBox4.Location = new Point(10, 320);
            textBox1.Text = twelveV[1].ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Mirror(true);
            pictureBox4.Location = new Point(10, 345);
            textBox1.Text = twelveV[0].ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Mirror(true);
            pictureBox4.Location = new Point(10, 370);
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Mirror(true);
            pictureBox4.Location = new Point(10, 370);
            textBox1.Text = threeV[2].ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Mirror(false);
            pictureBox4.Location = new Point(170, 345);
            textBox1.Text = fiveV[2].ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click_1(object sender, EventArgs e)
        {
        }

        private void button10_Click_2(object sender, EventArgs e)
        {
            Mirror(false);
            pictureBox4.Location = new Point(170, 320);
            textBox1.Text = fiveV[3].ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Mirror(false);
            pictureBox4.Location = new Point(170, 293);
            textBox1.Text = fiveV[4].ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Mirror(false);
            pictureBox4.Location = new Point(170, 95);
            textBox1.Text = threeV[3].ToString();
        }
    }
}
