namespace Exam
{
    partial class home
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(275, 36);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // button1
            // 
            button1.Location = new Point(275, 501);
            button1.Name = "button1";
            button1.Size = new Size(122, 57);
            button1.TabIndex = 1;
            button1.Text = "delete";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(467, 501);
            button2.Name = "button2";
            button2.Size = new Size(122, 57);
            button2.TabIndex = 2;
            button2.Text = "update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(275, 317);
            label1.Name = "label1";
            label1.Size = new Size(70, 28);
            label1.TabIndex = 3;
            label1.Text = "user id";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(404, 314);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(199, 34);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(404, 372);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(199, 34);
            textBox2.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(275, 375);
            label2.Name = "label2";
            label2.Size = new Size(96, 28);
            label2.TabIndex = 5;
            label2.Text = "username";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(404, 424);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(199, 34);
            textBox3.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(275, 427);
            label3.Name = "label3";
            label3.Size = new Size(95, 28);
            label3.TabIndex = 7;
            label3.Text = "password";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(275, 258);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(154, 28);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "add department";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(444, 258);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(159, 28);
            linkLabel2.TabIndex = 10;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "view department";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // home
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 645);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "home";
            Text = "home";
            Load += home_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
    }
}