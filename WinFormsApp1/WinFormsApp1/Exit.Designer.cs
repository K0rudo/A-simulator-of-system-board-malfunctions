namespace WinFormsApp1
{
    partial class Exit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            Bal = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(301, 89);
            label1.Name = "label1";
            label1.Size = new Size(259, 111);
            label1.TabIndex = 0;
            label1.Text = "Вы закончили тест.\r\n Поздравляю!!!!\r\n   Ваш балл:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += this.label1_Click;
            // 
            // Bal
            // 
            Bal.AutoSize = true;
            Bal.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Bal.Location = new Point(396, 213);
            Bal.Name = "Bal";
            Bal.Size = new Size(90, 37);
            Bal.TabIndex = 1;
            Bal.Text = "label2";
            Bal.Click += this.Bal_Click;
            // 
            // Exit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 477);
            Controls.Add(Bal);
            Controls.Add(label1);
            Name = "Exit";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Bal;
    }
}