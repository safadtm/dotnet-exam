namespace LibraryManagement
{
    partial class addbook
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
            button1 = new Button();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(305, 382);
            button1.Name = "button1";
            button1.Size = new Size(120, 58);
            button1.TabIndex = 16;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(380, 229);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(293, 34);
            textBox2.TabIndex = 13;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(189, 229);
            label3.Name = "label3";
            label3.Size = new Size(142, 28);
            label3.TabIndex = 12;
            label3.Text = "Book Category";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(380, 156);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(293, 34);
            textBox1.TabIndex = 11;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(189, 156);
            label2.Name = "label2";
            label2.Size = new Size(114, 28);
            label2.TabIndex = 10;
            label2.Text = "Book Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(305, 65);
            label1.Name = "label1";
            label1.Size = new Size(167, 46);
            label1.TabIndex = 9;
            label1.Text = "Add Book";
            // 
            // button2
            // 
            button2.Location = new Point(463, 382);
            button2.Name = "button2";
            button2.Size = new Size(120, 58);
            button2.TabIndex = 17;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // addbook
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 533);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "addbook";
            Text = "addbook";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Button button2;
    }
}