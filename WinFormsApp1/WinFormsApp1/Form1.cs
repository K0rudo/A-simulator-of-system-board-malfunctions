using Power_lines;
using RTC;
using System;
using WinFormsApp2;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public static class MyGlobals
        {
            public static int volt = 3;
            public static int prav;
            public static bool flag = false;
            public static int c = 0;
            public static int count = 10;
            public static string[] mas = ["Проверить исправен ли южный мост",
                "Проверить исправность RTC",
                "Проверить короткое замыкание на линиях +12В, +5В и +3.3В"
                ];
            public static string[] answerMost = ["Нужна замена Южного моста",
                "Нужна замена USB порта",
                "Ошибка отсутствует",
                "Просто подождать"
                ];
            public static string[] answerRTC = ["Нужна замена батарейка",
                "Не придумал",
                "Нужна замена кварцевого резонатора",
                "Ошибка отсутсвует"
                ];
            public static string[] answerKorot = ["Котороткого замыкания нет",
                "Короткое замыкание на линии +3.3В",
                "Короткое замыкание на линии +5В",
                "Короткое замыкание на линии +12В"
                ];
        }

        public Form1()
        {
            InitializeComponent();

            Random random = new Random();
            MyGlobals.prav = random.Next(0, 3);
            if (MyGlobals.prav != 2)
            {
                MyGlobals.volt = random.Next(0, 3);
            }

            Count.Text = "Баллы: " + Convert.ToString(MyGlobals.count) + "/10";

            answer.Hide();
            answer1.Hide();
            answer2.Hide();
            answer3.Hide();
            answer4.Hide();
            Trabl.Hide();
            pictureBox2.Hide();

            Trans(USB1);
            Trans(butRTC);
            Trans(vol);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < MyGlobals.mas.Length; i++)
            {
                if (MyGlobals.mas[i] == "")
                {
                    MyGlobals.c++;
                }
            }
            if (MyGlobals.c == MyGlobals.mas.Length)
            {
                MyGlobals.flag = true;
                this.Hide();
                Exit exit = new Exit();
                exit.Show();
                exit.Location = this.Location;
            }
            MyGlobals.c = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            generat.Enabled = false;
            if (MyGlobals.flag == false)
            {
                Trabl.Show();
                Random random = new Random();
                int i = random.Next(MyGlobals.mas.Length);
                while (MyGlobals.mas[i] == "")
                {
                    i = random.Next(MyGlobals.mas.Length);
                }
                string randomelement = MyGlobals.mas[i];
                Trabl.Text = randomelement;

                answer.Show();
                answer.Enabled = false;

                if (i == 0)
                {
                    Smena(MyGlobals.answerMost);
                }
                if (i == 1)
                {
                    Smena(MyGlobals.answerRTC);
                }
                if (i == 2)
                {
                    pictureBox2.Show();
                    Smena(MyGlobals.answerKorot);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void USB1_Click(object sender, EventArgs e)
        {
            FormUSB1 usb = new FormUSB1();
            usb.Show();
            usb.Location = this.Location;
        }

        private void answer1_CheckedChanged(object sender, EventArgs e)
        {
            Block(answer1, answer4, answer2, answer3, answer);
        }

        private void answer2_CheckedChanged(object sender, EventArgs e)
        {
            Block(answer2, answer1, answer4, answer3, answer);
        }

        private void answer3_CheckedChanged(object sender, EventArgs e)
        {
            Block(answer3, answer1, answer2, answer4, answer);
        }

        private void answer4_CheckedChanged(object sender, EventArgs e)
        {
            Block(answer4, answer1, answer2, answer3, answer);
        }

        private void answer_Click(object sender, EventArgs e)
        {
            if (Trabl.Text == MyGlobals.mas[0])
            {
                if (answer1.Checked == true && MyGlobals.prav != 0)
                {
                    MessageBox.Show("Вы ответили правильно на этот вопрос");
                    MyGlobals.mas[0] = "";
                    Form1_Load(sender, e);
                    button1_Click(sender, e);
                    answer1.Enabled = true;
                    answer2.Enabled = true;
                    answer3.Enabled = true;
                    answer4.Enabled = true;
                }
                else if (answer3.Checked == true && MyGlobals.prav == 0)
                {
                    MessageBox.Show("Вы ответили правильно на этот вопрос");
                    MyGlobals.mas[0] = "";
                    Form1_Load(sender, e);
                    button1_Click(sender, e);
                    answer1.Enabled = true;
                    answer2.Enabled = true;
                    answer3.Enabled = true;
                    answer4.Enabled = true;
                }
                else if (answer3.Checked == false || answer1.Checked == false)
                {
                    MessageBox.Show("Вы ответили неправильно.\nПодсказка: проверьте показания на USB портах");
                    MyGlobals.count--;
                    Count.Text = "Баллы: " + Convert.ToString(MyGlobals.count) + "/10";
                }
            }

            else if (Trabl.Text == MyGlobals.mas[1])
            {
                if (answer3.Checked == true && MyGlobals.prav != 1)
                {
                    MessageBox.Show("Вы ответили правильно на этот вопрос");
                    MyGlobals.mas[1] = "";
                    Form1_Load(sender, e);
                    button1_Click(sender, e);
                    answer1.Enabled = true;
                    answer2.Enabled = true;
                    answer3.Enabled = true;
                    answer4.Enabled = true;
                }
                else if (answer4.Checked == true && MyGlobals.prav == 1)
                {
                    MessageBox.Show("Вы ответили правильно на этот вопрос");
                    MyGlobals.mas[1] = "";
                    Form1_Load(sender, e);
                    button1_Click(sender, e);
                    answer1.Enabled = true;
                    answer2.Enabled = true;
                    answer3.Enabled = true;
                    answer4.Enabled = true;
                }
                else if (answer3.Checked == false || answer4.Checked == false)
                {
                    MessageBox.Show("Вы ответили неправильно.\nПодсказка:Перепроверьте показания на кварцевом резонаторе");
                    MyGlobals.count--;
                    Count.Text = "Баллы: " + Convert.ToString(MyGlobals.count) + "/10";
                }
            }

            else if (Trabl.Text == MyGlobals.mas[2])
            {
                if (answer1.Checked == true && MyGlobals.prav == 2)
                {
                    MessageBox.Show("Вы ответили правильно на этот вопрос");
                    MyGlobals.mas[2] = "";
                    Form1_Load(sender, e);
                    button1_Click(sender, e);
                    answer1.Enabled = true;
                    answer2.Enabled = true;
                    answer3.Enabled = true;
                    answer4.Enabled = true;
                    pictureBox2.Hide();
                }
                else if (answer2.Checked == true && MyGlobals.prav != 2 && MyGlobals.volt == 0)
                {
                    MessageBox.Show("Вы ответили правильно на этот вопрос");
                    MyGlobals.mas[2] = "";
                    Form1_Load(sender, e);
                    button1_Click(sender, e);
                    answer1.Enabled = true;
                    answer2.Enabled = true;
                    answer3.Enabled = true;
                    answer4.Enabled = true;
                    pictureBox2.Hide();
                }
                else if (answer3.Checked == true && MyGlobals.prav != 2 && MyGlobals.volt == 1)
                {
                    MessageBox.Show("Вы ответили правильно на этот вопрос");
                    MyGlobals.mas[2] = "";
                    Form1_Load(sender, e);
                    button1_Click(sender, e);
                    answer1.Enabled = true;
                    answer2.Enabled = true;
                    answer3.Enabled = true;
                    answer4.Enabled = true;
                    pictureBox2.Hide();
                }
                else if (answer4.Checked == true && MyGlobals.prav != 2 && MyGlobals.volt == 2)
                {
                    MessageBox.Show("Вы ответили правильно на этот вопрос");
                    MyGlobals.mas[2] = "";
                    Form1_Load(sender, e);
                    button1_Click(sender, e);
                    answer1.Enabled = true;
                    answer2.Enabled = true;
                    answer3.Enabled = true;
                    answer4.Enabled = true;
                    pictureBox2.Hide();
                }
                else if (answer2.Checked == false || answer1.Checked == false || answer3.Checked == false || answer4.Checked == false)
                {
                    MessageBox.Show("Вы ответили неправильно.");
                    MyGlobals.count--;
                    Count.Text = "Баллы: " + Convert.ToString(MyGlobals.count) + "/10";
                }
            }
        }

        private void Count_Click(object sender, EventArgs e)
        {

        }
        public void Smena(string[] el)
        {
            answer1.Show();
            answer1.Text = el[0];
            answer2.Show();
            answer2.Text = el[1];
            answer3.Show();
            answer3.Text = el[2];
            answer4.Show();
            answer4.Text = el[3];
        }
        public void Block(CheckBox T, CheckBox F_1, CheckBox F_2, CheckBox F_3, Button ans)
        {
            if (T.Checked == true)
            {
                ans.Enabled = true;

                F_1.Enabled = false;
                F_2.Enabled = false;
                F_3.Enabled = false;
            }
            else
            {
                ans.Enabled = false;

                F_1.Enabled = true;
                F_2.Enabled = true;
                F_3.Enabled = true;
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
        private void butRTC_Click(object sender, EventArgs e)
        {
            FormRTC rtc = new FormRTC();
            rtc.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Здраствйте, это инструкция по прохождению теста" +
                "\n В начале вам следует нажать кнопку 'начать тест'" +
                "\n Теперь вы можете увидеть ошибку на материнской плате и 4 варианта ответа, но учтите что только один правильный." +
                "\n Пока вы не выберите вариант ответы вы не сможете проверить себя" +
                ", а также когда вы вибираете один из вариантов остальные становятся недоступны." +
                "\n Для того чтобы определить правильный вариант ответа вы можете поискать на материнской плате кнопки к соответствующим ее элементам и проверить их показания с помощью приборов." +
                "\n А если вы неправильно ответите на вопрос то вам дается подсказка и отнимается 1 балл." +
                "\n Также учитывайте что один из вопросов будет целенаправленно ПРАВИЛЬНЫМ(какой из вопрос будет правильным выбирается случайным образом также как порядок вопросов)." +
                "\n Желаю удачи");
        }

        private void vol_Click(object sender, EventArgs e)
        {
            FormVolt Volt = new FormVolt();
            Volt.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void name_Click(object sender, EventArgs e)
        {

        }
    }
}
