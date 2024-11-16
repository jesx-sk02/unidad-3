namespace Practica_6
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
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(68, 9);
            label1.Name = "label1";
            label1.Size = new Size(326, 45);
            label1.TabIndex = 0;
            label1.Text = "Area de un triangulo";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.RosyBrown;
            textBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.Window;
            textBox1.Location = new Point(176, 89);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(218, 34);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.BackColor = Color.SaddleBrown;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(68, 325);
            button1.Name = "button1";
            button1.Size = new Size(326, 41);
            button1.TabIndex = 2;
            button1.Text = "CALULAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.e346136358376469cbef5f0aaba2a7e9_removebg_preview;
            pictureBox1.Location = new Point(428, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(242, 287);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(68, 95);
            label2.Name = "label2";
            label2.Size = new Size(56, 28);
            label2.TabIndex = 4;
            label2.Text = "Base";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(68, 141);
            label3.Name = "label3";
            label3.Size = new Size(71, 28);
            label3.TabIndex = 5;
            label3.Text = "Altura";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(68, 231);
            label4.Name = "label4";
            label4.Size = new Size(142, 28);
            label4.TabIndex = 6;
            label4.Text = "El area es de :";
            label4.Click += label4_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.RosyBrown;
            textBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.ForeColor = SystemColors.Window;
            textBox2.Location = new Point(176, 141);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(218, 34);
            textBox2.TabIndex = 7;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.RosyBrown;
            textBox3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.ForeColor = SystemColors.Window;
            textBox3.Location = new Point(216, 231);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(178, 34);
            textBox3.TabIndex = 8;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(673, 396);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}
