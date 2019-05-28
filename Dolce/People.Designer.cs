namespace Dolce
{
    partial class People
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
            this.ImieLabel = new System.Windows.Forms.Label();
            this.NazwiskoLabel = new System.Windows.Forms.Label();
            this.PeselLabel = new System.Windows.Forms.Label();
            this.OsobaCombo = new System.Windows.Forms.ComboBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.Imie = new System.Windows.Forms.TextBox();
            this.Nazwisko = new System.Windows.Forms.TextBox();
            this.Pesel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ImieLabel
            // 
            this.ImieLabel.AutoSize = true;
            this.ImieLabel.Location = new System.Drawing.Point(65, 167);
            this.ImieLabel.Name = "ImieLabel";
            this.ImieLabel.Size = new System.Drawing.Size(51, 25);
            this.ImieLabel.TabIndex = 0;
            this.ImieLabel.Text = "Imię";
            // 
            // NazwiskoLabel
            // 
            this.NazwiskoLabel.AutoSize = true;
            this.NazwiskoLabel.Location = new System.Drawing.Point(65, 227);
            this.NazwiskoLabel.Name = "NazwiskoLabel";
            this.NazwiskoLabel.Size = new System.Drawing.Size(104, 25);
            this.NazwiskoLabel.TabIndex = 1;
            this.NazwiskoLabel.Text = "Nazwisko";
            // 
            // PeselLabel
            // 
            this.PeselLabel.AutoSize = true;
            this.PeselLabel.Location = new System.Drawing.Point(65, 289);
            this.PeselLabel.Name = "PeselLabel";
            this.PeselLabel.Size = new System.Drawing.Size(66, 25);
            this.PeselLabel.TabIndex = 2;
            this.PeselLabel.Text = "Pesel";
            // 
            // OsobaCombo
            // 
            this.OsobaCombo.FormattingEnabled = true;
            this.OsobaCombo.Location = new System.Drawing.Point(439, 77);
            this.OsobaCombo.Name = "OsobaCombo";
            this.OsobaCombo.Size = new System.Drawing.Size(284, 33);
            this.OsobaCombo.TabIndex = 3;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(693, 829);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(306, 54);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Zapisz";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Imie
            // 
            this.Imie.Location = new System.Drawing.Point(365, 159);
            this.Imie.Name = "Imie";
            this.Imie.Size = new System.Drawing.Size(272, 31);
            this.Imie.TabIndex = 5;
            // 
            // Nazwisko
            // 
            this.Nazwisko.Location = new System.Drawing.Point(359, 215);
            this.Nazwisko.Name = "Nazwisko";
            this.Nazwisko.Size = new System.Drawing.Size(277, 31);
            this.Nazwisko.TabIndex = 6;
            // 
            // Pesel
            // 
            this.Pesel.Location = new System.Drawing.Point(359, 289);
            this.Pesel.Name = "Pesel";
            this.Pesel.Size = new System.Drawing.Size(300, 31);
            this.Pesel.TabIndex = 7;
            // 
            // People
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1674, 974);
            this.Controls.Add(this.Pesel);
            this.Controls.Add(this.Nazwisko);
            this.Controls.Add(this.Imie);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.OsobaCombo);
            this.Controls.Add(this.PeselLabel);
            this.Controls.Add(this.NazwiskoLabel);
            this.Controls.Add(this.ImieLabel);
            this.Name = "People";
            this.Text = "People";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ImieLabel;
        private System.Windows.Forms.Label NazwiskoLabel;
        private System.Windows.Forms.Label PeselLabel;
        private System.Windows.Forms.ComboBox OsobaCombo;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox Imie;
        private System.Windows.Forms.TextBox Nazwisko;
        private System.Windows.Forms.TextBox Pesel;
    }
}