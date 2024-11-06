namespace LibraryManagement
{
    partial class loginform
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
            textBox3 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(333, 315);
            button2.Name = "button2";
            button2.Size = new Size(120, 58);
            button2.TabIndex = 17;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(293, 225);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(293, 34);
            textBox3.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(164, 227);
            label4.Name = "label4";
            label4.Size = new Size(93, 28);
            label4.TabIndex = 14;
            label4.Text = "Password";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(293, 160);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(293, 34);
            textBox2.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(164, 162);
            label3.Name = "label3";
            label3.Size = new Size(59, 28);
            label3.TabIndex = 12;
            label3.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(305, 52);
            label1.Name = "label1";
            label1.Size = new Size(103, 46);
            label1.TabIndex = 9;
            label1.Text = "Login";
            // 
            // loginform
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(button2);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "loginform";
            Text = "loginform";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private Label label1;
    }
}