namespace SerwisKomputerowy
{
    partial class Form5
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
            textBoxNumerZlecenia = new TextBox();
            textBoxRodzajKomputera = new TextBox();
            textBoxKolorKomputera = new TextBox();
            textBoxUwageOdKlienta = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            button1 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBoxNumerZlecenia
            // 
            textBoxNumerZlecenia.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNumerZlecenia.Location = new Point(417, 74);
            textBoxNumerZlecenia.Name = "textBoxNumerZlecenia";
            textBoxNumerZlecenia.Size = new Size(240, 38);
            textBoxNumerZlecenia.TabIndex = 0;
            textBoxNumerZlecenia.TextChanged += textBoxNumerZlecenia_TextChanged;
            // 
            // textBoxRodzajKomputera
            // 
            textBoxRodzajKomputera.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxRodzajKomputera.Location = new Point(417, 118);
            textBoxRodzajKomputera.Name = "textBoxRodzajKomputera";
            textBoxRodzajKomputera.Size = new Size(240, 38);
            textBoxRodzajKomputera.TabIndex = 1;
            // 
            // textBoxKolorKomputera
            // 
            textBoxKolorKomputera.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxKolorKomputera.Location = new Point(417, 168);
            textBoxKolorKomputera.Name = "textBoxKolorKomputera";
            textBoxKolorKomputera.Size = new Size(240, 38);
            textBoxKolorKomputera.TabIndex = 2;
            // 
            // textBoxUwageOdKlienta
            // 
            textBoxUwageOdKlienta.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUwageOdKlienta.Location = new Point(417, 212);
            textBoxUwageOdKlienta.Name = "textBoxUwageOdKlienta";
            textBoxUwageOdKlienta.Size = new Size(240, 38);
            textBoxUwageOdKlienta.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(59, 77);
            label1.Name = "label1";
            label1.Size = new Size(352, 31);
            label1.TabIndex = 6;
            label1.Text = "Dodaj numer zlecenia komputera";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(150, 121);
            label2.Name = "label2";
            label2.Size = new Size(261, 31);
            label2.TabIndex = 7;
            label2.Text = "Dodaj rodzaj komputera";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(162, 168);
            label3.Name = "label3";
            label3.Size = new Size(249, 31);
            label3.TabIndex = 8;
            label3.Text = "Dodaj kolor komputera";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(155, 213);
            label5.Name = "label5";
            label5.Size = new Size(256, 31);
            label5.TabIndex = 10;
            label5.Text = "Dodaj uwagę od klienta";
            label5.Click += label5_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(319, 277);
            button1.Name = "button1";
            button1.Size = new Size(201, 43);
            button1.TabIndex = 12;
            button1.Text = "Dodaj zlecenie";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(146, 9);
            label4.Name = "label4";
            label4.Size = new Size(515, 41);
            label4.TabIndex = 13;
            label4.Text = "Uzupełnij dane dla danego zlecenia";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxUwageOdKlienta);
            Controls.Add(textBoxKolorKomputera);
            Controls.Add(textBoxRodzajKomputera);
            Controls.Add(textBoxNumerZlecenia);
            Name = "Form5";
            Text = "Form5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNumerZlecenia;
        private TextBox textBoxRodzajKomputera;
        private TextBox textBoxKolorKomputera;
        private TextBox textBoxUwageOdKlienta;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Button button1;
        private Label label4;
    }
}