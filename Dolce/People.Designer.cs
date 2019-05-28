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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ImieLabel
            // 
            this.ImieLabel.AutoSize = true;
            this.ImieLabel.Location = new System.Drawing.Point(27, 161);
            this.ImieLabel.Name = "ImieLabel";
            this.ImieLabel.Size = new System.Drawing.Size(51, 25);
            this.ImieLabel.TabIndex = 0;
            this.ImieLabel.Text = "Imię";
            // 
            // NazwiskoLabel
            // 
            this.NazwiskoLabel.AutoSize = true;
            this.NazwiskoLabel.Location = new System.Drawing.Point(27, 221);
            this.NazwiskoLabel.Name = "NazwiskoLabel";
            this.NazwiskoLabel.Size = new System.Drawing.Size(104, 25);
            this.NazwiskoLabel.TabIndex = 1;
            this.NazwiskoLabel.Text = "Nazwisko";
            // 
            // PeselLabel
            // 
            this.PeselLabel.AutoSize = true;
            this.PeselLabel.Location = new System.Drawing.Point(27, 283);
            this.PeselLabel.Name = "PeselLabel";
            this.PeselLabel.Size = new System.Drawing.Size(66, 25);
            this.PeselLabel.TabIndex = 2;
            this.PeselLabel.Text = "Pesel";
            // 
            // OsobaCombo
            // 
            this.OsobaCombo.FormattingEnabled = true;
            this.OsobaCombo.Location = new System.Drawing.Point(219, 99);
            this.OsobaCombo.Name = "OsobaCombo";
            this.OsobaCombo.Size = new System.Drawing.Size(418, 33);
            this.OsobaCombo.TabIndex = 3;
            this.OsobaCombo.TextChanged += new System.EventHandler(this.OsobaCombo_TextChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(219, 377);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(306, 54);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Zapisz";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Imie
            // 
            this.Imie.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.Imie.Location = new System.Drawing.Point(219, 158);
            this.Imie.Name = "Imie";
            this.Imie.Size = new System.Drawing.Size(418, 31);
            this.Imie.TabIndex = 5;
            // 
            // Nazwisko
            // 
            this.Nazwisko.Location = new System.Drawing.Point(219, 218);
            this.Nazwisko.Name = "Nazwisko";
            this.Nazwisko.Size = new System.Drawing.Size(418, 31);
            this.Nazwisko.TabIndex = 6;
            // 
            // Pesel
            // 
            this.Pesel.Location = new System.Drawing.Point(219, 283);
            this.Pesel.Name = "Pesel";
            this.Pesel.Size = new System.Drawing.Size(418, 31);
            this.Pesel.TabIndex = 7;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TitleLabel.Location = new System.Drawing.Point(25, 25);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(195, 37);
            this.TitleLabel.TabIndex = 8;
            this.TitleLabel.Text = "Edytor Osób";
            // 
            // People
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 466);
            this.Controls.Add(this.TitleLabel);
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
        private System.Windows.Forms.Label TitleLabel;
    }
}