namespace Exam
{
    partial class login
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
            button2 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(278, 316);
            button2.Name = "button2";
            button2.Size = new Size(149, 51);
            button2.TabIndex = 13;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(341, 224);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(219, 34);
            textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(341, 154);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(219, 34);
            textBox1.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(167, 218);
            label3.Name = "label3";
            label3.Size = new Size(95, 28);
            label3.TabIndex = 9;
            label3.Text = "password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(167, 154);
            label2.Name = "label2";
            label2.Size = new Size(96, 28);
            label2.TabIndex = 8;
            label2.Text = "username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(324, 40);
            label1.Name = "label1";
            label1.Size = new Size(61, 28);
            label1.TabIndex = 7;
            label1.Text = "Login";
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "login";
            Text = "login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}