namespace SerwisKomputerowy
{
    partial class Form8
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
            label2 = new Label();
            textBoxIMIE = new TextBox();
            textBox2NAZWISKO = new TextBox();
            button1 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(234, 86);
            label1.Name = "label1";
            label1.Size = new Size(58, 31);
            label1.TabIndex = 0;
            label1.Text = "Imię";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(182, 127);
            label2.Name = "label2";
            label2.Size = new Size(110, 31);
            label2.TabIndex = 1;
            label2.Text = "Nazwisko";
            // 
            // textBoxIMIE
            // 
            textBoxIMIE.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxIMIE.Location = new Point(298, 83);
            textBoxIMIE.Name = "textBoxIMIE";
            textBoxIMIE.Size = new Size(211, 38);
            textBoxIMIE.TabIndex = 2;
            // 
            // textBox2NAZWISKO
            // 
            textBox2NAZWISKO.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2NAZWISKO.Location = new Point(298, 127);
            textBox2NAZWISKO.Name = "textBox2NAZWISKO";
            textBox2NAZWISKO.Size = new Size(211, 38);
            textBox2NAZWISKO.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(269, 171);
            button1.Name = "button1";
            button1.Size = new Size(254, 46);
            button1.TabIndex = 4;
            button1.Text = "Usuń danego klienta";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(234, 9);
            label3.Name = "label3";
            label3.Size = new Size(360, 41);
            label3.TabIndex = 5;
            label3.Text = "Usuń dla danego klienta";
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(textBox2NAZWISKO);
            Controls.Add(textBoxIMIE);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form8";
            Text = "Form8";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxIMIE;
        private TextBox textBox2NAZWISKO;
        private Button button1;
        private Label label3;
    }
}