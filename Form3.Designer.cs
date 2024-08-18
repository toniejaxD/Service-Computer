namespace SerwisKomputerowy
{
    partial class Form3
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
            textBoxIMIE = new TextBox();
            textBox2NAZWISKO = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBoxIMIE
            // 
            textBoxIMIE.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxIMIE.Location = new Point(330, 74);
            textBoxIMIE.Name = "textBoxIMIE";
            textBoxIMIE.Size = new Size(233, 38);
            textBoxIMIE.TabIndex = 0;
            textBoxIMIE.TextChanged += textBoxIMIE_TextChanged;
            // 
            // textBox2NAZWISKO
            // 
            textBox2NAZWISKO.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2NAZWISKO.Location = new Point(330, 118);
            textBox2NAZWISKO.Name = "textBox2NAZWISKO";
            textBox2NAZWISKO.Size = new Size(233, 38);
            textBox2NAZWISKO.TabIndex = 1;
            textBox2NAZWISKO.TextChanged += textBox2NAZWISKO_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(347, 162);
            button1.Name = "button1";
            button1.Size = new Size(202, 40);
            button1.TabIndex = 6;
            button1.Text = "Dodaj klienta";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(203, 81);
            label2.Name = "label2";
            label2.Size = new Size(121, 31);
            label2.TabIndex = 12;
            label2.Text = "Podaj imię";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(155, 118);
            label3.Name = "label3";
            label3.Size = new Size(169, 31);
            label3.TabIndex = 13;
            label3.Text = "Podaj nazwisko";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(203, 9);
            label1.Name = "label1";
            label1.Size = new Size(386, 41);
            label1.TabIndex = 14;
            label1.Text = "Uzupełnij dane dla klienta";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox2NAZWISKO);
            Controls.Add(textBoxIMIE);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxIMIE;
        private TextBox textBox2NAZWISKO;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label1;
    }
}