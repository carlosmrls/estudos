namespace Calculos
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
            mais = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button2 = new Button();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            multiplicaçao = new Button();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            divisao = new Button();
            SuspendLayout();
            // 
            // mais
            // 
            mais.Location = new Point(229, 13);
            mais.Name = "mais";
            mais.Size = new Size(75, 23);
            mais.TabIndex = 0;
            mais.Text = "menos";
            mais.UseVisualStyleBackColor = true;
            mais.Click += mais_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(9, 13);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(115, 14);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(115, 57);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(9, 57);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(229, 56);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "mais";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(9, 98);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 6;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(115, 98);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 7;
            // 
            // multiplicaçao
            // 
            multiplicaçao.Location = new Point(229, 98);
            multiplicaçao.Name = "multiplicaçao";
            multiplicaçao.Size = new Size(75, 23);
            multiplicaçao.TabIndex = 8;
            multiplicaçao.Text = "multiplicaçao";
            multiplicaçao.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(9, 138);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 9;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(115, 138);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 10;
            // 
            // divisao
            // 
            divisao.Location = new Point(229, 138);
            divisao.Name = "divisao";
            divisao.Size = new Size(75, 23);
            divisao.TabIndex = 11;
            divisao.Text = "divisao";
            divisao.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 171);
            Controls.Add(divisao);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(multiplicaçao);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(button2);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(mais);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button mais;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button2;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button multiplicaçao;
        private TextBox textBox7;
        private TextBox textBox8;
        private Button divisao;
    }
}
