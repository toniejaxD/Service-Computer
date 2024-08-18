namespace SerwisKomputerowy
{
    partial class Form9
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
            textBoxNumerZlecenia = new TextBox();
            button1 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(74, 64);
            label1.Name = "label1";
            label1.Size = new Size(289, 31);
            label1.TabIndex = 0;
            label1.Text = "Numer zlecenia komputera";
            // 
            // textBoxNumerZlecenia
            // 
            textBoxNumerZlecenia.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNumerZlecenia.Location = new Point(369, 61);
            textBoxNumerZlecenia.Name = "textBoxNumerZlecenia";
            textBoxNumerZlecenia.Size = new Size(283, 38);
            textBoxNumerZlecenia.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(227, 116);
            button1.Name = "button1";
            button1.Size = new Size(342, 45);
            button1.TabIndex = 2;
            button1.Text = "Usuń dla danego zlecenia";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(206, 9);
            label2.Name = "label2";
            label2.Size = new Size(375, 41);
            label2.TabIndex = 3;
            label2.Text = "Usuń dla danego zlecenia";
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBoxNumerZlecenia);
            Controls.Add(label1);
            Name = "Form9";
            Text = "Form9";
            Load += Form9_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxNumerZlecenia;
        private Button button1;
        private Label label2;
    }
}