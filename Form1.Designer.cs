namespace SerwisKomputerowy
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
            button4 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            ExportButton_Click = new Button();
            ImportButton_Click = new Button();
            button12 = new Button();
            button13 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(190, 45);
            label1.Name = "label1";
            label1.Size = new Size(527, 41);
            label1.TabIndex = 2;
            label1.Text = "Serwis komputerowy \"Komputerek\"";
            // 
            // button4
            // 
            button4.Location = new Point(342, 402);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(247, 31);
            button4.TabIndex = 7;
            button4.Text = "Usuń wszytkie dane w bazie SQL";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button8
            // 
            button8.Location = new Point(340, 120);
            button8.Name = "button8";
            button8.Size = new Size(247, 29);
            button8.TabIndex = 11;
            button8.Text = "Wejdź zakładkę listy klientów";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(341, 190);
            button9.Name = "button9";
            button9.Size = new Size(248, 29);
            button9.TabIndex = 12;
            button9.Text = "Wejdź zakładkę dodawanie klienta";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(340, 155);
            button10.Name = "button10";
            button10.Size = new Size(247, 29);
            button10.TabIndex = 13;
            button10.Text = "Wejdź zakładkę listy zleceń";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Location = new Point(341, 225);
            button11.Name = "button11";
            button11.Size = new Size(248, 29);
            button11.TabIndex = 14;
            button11.Text = "Wejdź zakładkę dodawanie zleceń";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // ExportButton_Click
            // 
            ExportButton_Click.Location = new Point(340, 331);
            ExportButton_Click.Name = "ExportButton_Click";
            ExportButton_Click.Size = new Size(247, 29);
            ExportButton_Click.TabIndex = 15;
            ExportButton_Click.Text = "Exportuj dane xlm";
            ExportButton_Click.UseVisualStyleBackColor = true;
            ExportButton_Click.Click += ExportButton_Click_Click;
            // 
            // ImportButton_Click
            // 
            ImportButton_Click.Location = new Point(342, 366);
            ImportButton_Click.Name = "ImportButton_Click";
            ImportButton_Click.Size = new Size(247, 29);
            ImportButton_Click.TabIndex = 16;
            ImportButton_Click.Text = "Importuj dane xlm";
            ImportButton_Click.UseVisualStyleBackColor = true;
            ImportButton_Click.Click += ImportButton_Click_Click;
            // 
            // button12
            // 
            button12.Location = new Point(342, 260);
            button12.Name = "button12";
            button12.Size = new Size(245, 29);
            button12.TabIndex = 17;
            button12.Text = "Usuń danego klienta";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.Location = new Point(342, 295);
            button13.Name = "button13";
            button13.Size = new Size(245, 29);
            button13.TabIndex = 18;
            button13.Text = "Usuń dane zlecenia";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(ImportButton_Click);
            Controls.Add(ExportButton_Click);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button4);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button button4;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button ExportButton_Click;
        private Button ImportButton_Click;
        private Button button12;
        private Button button13;
    }
}