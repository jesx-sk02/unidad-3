﻿namespace Ejercicio_5
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
            label2 = new Label();
            button1 = new Button();
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(67, 9);
            label1.Name = "label1";
            label1.Size = new Size(492, 38);
            label1.TabIndex = 0;
            label1.Text = "Verifica si un número es par o impar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(67, 114);
            label2.Name = "label2";
            label2.Size = new Size(188, 28);
            label2.TabIndex = 1;
            label2.Text = "Escribe un número";
            // 
            // button1
            // 
            button1.BackColor = Color.MediumVioletRed;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(67, 206);
            button1.Name = "button1";
            button1.Size = new Size(188, 45);
            button1.TabIndex = 2;
            button1.Text = "verifica";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(344, 107);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(215, 144);
            listBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Thistle;
            textBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(67, 145);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(188, 34);
            textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(636, 347);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private ListBox listBox1;
        private TextBox textBox1;
    }
}
