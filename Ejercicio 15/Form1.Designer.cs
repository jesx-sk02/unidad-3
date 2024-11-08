namespace Ejercicio_15
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(85, 110);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(124, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(260, 110);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(123, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(434, 110);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(85, 330);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(124, 27);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(260, 330);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(123, 27);
            textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(434, 330);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(200, 40);
            label1.Name = "label1";
            label1.Size = new Size(266, 20);
            label1.TabIndex = 6;
            label1.Text = "Ordenar 3 numeros de mayor a menor ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(130, 149);
            label2.Name = "label2";
            label2.Size = new Size(23, 20);
            label2.TabIndex = 7;
            label2.Text = "A ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(305, 149);
            label3.Name = "label3";
            label3.Size = new Size(18, 20);
            label3.TabIndex = 8;
            label3.Text = "B";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(486, 149);
            label4.Name = "label4";
            label4.Size = new Size(22, 20);
            label4.TabIndex = 9;
            label4.Text = "C ";
            // 
            // button1
            // 
            button1.Location = new Point(90, 238);
            button1.Name = "button1";
            button1.Size = new Size(98, 33);
            button1.TabIndex = 10;
            button1.Text = "Ordenar ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(275, 240);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 11;
            button2.Text = "Borrar ";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(446, 238);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 12;
            button3.Text = "Salir ";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Ordenar de mayor a menor ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
