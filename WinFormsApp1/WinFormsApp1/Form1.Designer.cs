namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            generat = new Button();
            pictureBox1 = new PictureBox();
            name = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            Trabl = new TextBox();
            USB1 = new Button();
            answer = new Button();
            answer1 = new CheckBox();
            answer2 = new CheckBox();
            answer3 = new CheckBox();
            answer4 = new CheckBox();
            Count = new Label();
            butRTC = new Button();
            Info = new Button();
            vol = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // generat
            // 
            generat.Location = new Point(745, 71);
            generat.Name = "generat";
            generat.Size = new Size(179, 24);
            generat.TabIndex = 0;
            generat.Text = "Начать тест";
            generat.UseVisualStyleBackColor = true;
            generat.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(7, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(650, 723);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            name.Location = new Point(41, 9);
            name.Name = "name";
            name.Size = new Size(584, 37);
            name.TabIndex = 2;
            name.Text = "Материнская плата Gigabyte GA-B450M DS3H";
            name.Click += name_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Trabl
            // 
            Trabl.Location = new Point(674, 115);
            Trabl.Multiline = true;
            Trabl.Name = "Trabl";
            Trabl.Size = new Size(309, 53);
            Trabl.TabIndex = 4;
            Trabl.TextChanged += textBox1_TextChanged;
            // 
            // USB1
            // 
            USB1.Location = new Point(27, 260);
            USB1.Name = "USB1";
            USB1.Size = new Size(56, 93);
            USB1.TabIndex = 5;
            USB1.UseVisualStyleBackColor = true;
            USB1.Click += USB1_Click;
            // 
            // answer
            // 
            answer.Location = new Point(745, 274);
            answer.Name = "answer";
            answer.Size = new Size(179, 27);
            answer.TabIndex = 6;
            answer.Text = "Дать ответ";
            answer.UseVisualStyleBackColor = true;
            answer.Click += answer_Click;
            // 
            // answer1
            // 
            answer1.AutoSize = true;
            answer1.Location = new Point(674, 174);
            answer1.Name = "answer1";
            answer1.Size = new Size(83, 19);
            answer1.TabIndex = 7;
            answer1.Text = "checkBox1";
            answer1.UseVisualStyleBackColor = true;
            answer1.CheckedChanged += answer1_CheckedChanged;
            // 
            // answer2
            // 
            answer2.AutoSize = true;
            answer2.Location = new Point(674, 199);
            answer2.Name = "answer2";
            answer2.Size = new Size(83, 19);
            answer2.TabIndex = 8;
            answer2.Text = "checkBox1";
            answer2.UseVisualStyleBackColor = true;
            answer2.CheckedChanged += answer2_CheckedChanged;
            // 
            // answer3
            // 
            answer3.AutoSize = true;
            answer3.Location = new Point(674, 224);
            answer3.Name = "answer3";
            answer3.Size = new Size(83, 19);
            answer3.TabIndex = 9;
            answer3.Text = "checkBox1";
            answer3.UseVisualStyleBackColor = true;
            answer3.CheckedChanged += answer3_CheckedChanged;
            // 
            // answer4
            // 
            answer4.AutoSize = true;
            answer4.Location = new Point(674, 249);
            answer4.Name = "answer4";
            answer4.Size = new Size(83, 19);
            answer4.TabIndex = 10;
            answer4.Text = "checkBox1";
            answer4.UseVisualStyleBackColor = true;
            answer4.CheckedChanged += answer4_CheckedChanged;
            // 
            // Count
            // 
            Count.AutoSize = true;
            Count.Location = new Point(908, 741);
            Count.Name = "Count";
            Count.Size = new Size(38, 15);
            Count.TabIndex = 11;
            Count.Text = "label1";
            Count.Click += Count_Click;
            // 
            // butRTC
            // 
            butRTC.Location = new Point(181, 350);
            butRTC.Name = "butRTC";
            butRTC.Size = new Size(41, 36);
            butRTC.TabIndex = 12;
            butRTC.UseVisualStyleBackColor = true;
            butRTC.Click += butRTC_Click;
            // 
            // Info
            // 
            Info.Location = new Point(674, 733);
            Info.Name = "Info";
            Info.Size = new Size(96, 31);
            Info.TabIndex = 13;
            Info.Text = "Инструкция";
            Info.UseVisualStyleBackColor = true;
            Info.Click += Info_Click;
            // 
            // vol
            // 
            vol.Location = new Point(586, 172);
            vol.Name = "vol";
            vol.Size = new Size(27, 142);
            vol.TabIndex = 14;
            vol.UseVisualStyleBackColor = true;
            vol.Click += vol_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(670, 319);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(313, 408);
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(995, 777);
            Controls.Add(pictureBox2);
            Controls.Add(vol);
            Controls.Add(Info);
            Controls.Add(butRTC);
            Controls.Add(Count);
            Controls.Add(answer4);
            Controls.Add(answer3);
            Controls.Add(answer2);
            Controls.Add(answer1);
            Controls.Add(answer);
            Controls.Add(USB1);
            Controls.Add(Trabl);
            Controls.Add(name);
            Controls.Add(pictureBox1);
            Controls.Add(generat);
            Name = "Form1";
            Text = "Симулятор неисправностей материнской платы Gigabyte GA-B450M DS3H";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button generat;
        private PictureBox pictureBox1;
        private Label name;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox Trabl;
        private Button USB1;
        private Button answer;
        private CheckBox answer1;
        private CheckBox answer2;
        private CheckBox answer3;
        private CheckBox answer4;
        private Label Count;
        private Button butRTC;
        private Button Info;
        private Button vol;
        private PictureBox pictureBox2;
    }
}
