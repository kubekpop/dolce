namespace Dolce
{
    partial class AddNew
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
            this.KtoCombo = new System.Windows.Forms.ComboBox();
            this.KtoLabel = new System.Windows.Forms.Label();
            this.KomuLabel = new System.Windows.Forms.Label();
            this.KomuCombo = new System.Windows.Forms.ComboBox();
            this.IleLabel = new System.Windows.Forms.Label();
            this.Ile = new System.Windows.Forms.NumericUpDown();
            this.OpisLabel = new System.Windows.Forms.Label();
            this.Opis = new System.Windows.Forms.RichTextBox();
            this.Dodaj = new System.Windows.Forms.Button();
            this.Rozliczone = new System.Windows.Forms.CheckBox();
            this.EditLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Ile)).BeginInit();
            this.SuspendLayout();
            // 
            // KtoCombo
            // 
            this.KtoCombo.FormattingEnabled = true;
            this.KtoCombo.Items.AddRange(new object[] {
            "Kubix",
            "Krzysio",
            "Karol",
            "Kubek"});
            this.KtoCombo.Location = new System.Drawing.Point(204, 85);
            this.KtoCombo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.KtoCombo.Name = "KtoCombo";
            this.KtoCombo.Size = new System.Drawing.Size(238, 33);
            this.KtoCombo.TabIndex = 0;
            // 
            // KtoLabel
            // 
            this.KtoLabel.AutoSize = true;
            this.KtoLabel.Location = new System.Drawing.Point(24, 90);
            this.KtoLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.KtoLabel.Name = "KtoLabel";
            this.KtoLabel.Size = new System.Drawing.Size(44, 25);
            this.KtoLabel.TabIndex = 1;
            this.KtoLabel.Text = "Kto";
            // 
            // KomuLabel
            // 
            this.KomuLabel.AutoSize = true;
            this.KomuLabel.Location = new System.Drawing.Point(30, 179);
            this.KomuLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.KomuLabel.Name = "KomuLabel";
            this.KomuLabel.Size = new System.Drawing.Size(67, 25);
            this.KomuLabel.TabIndex = 2;
            this.KomuLabel.Text = "Komu";
            // 
            // KomuCombo
            // 
            this.KomuCombo.FormattingEnabled = true;
            this.KomuCombo.Items.AddRange(new object[] {
            "Kuba",
            "Winni",
            "Kot Karola",
            "Kebab",
            "Picie u kubixa"});
            this.KomuCombo.Location = new System.Drawing.Point(204, 179);
            this.KomuCombo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.KomuCombo.Name = "KomuCombo";
            this.KomuCombo.Size = new System.Drawing.Size(238, 33);
            this.KomuCombo.TabIndex = 3;
            // 
            // IleLabel
            // 
            this.IleLabel.AutoSize = true;
            this.IleLabel.Location = new System.Drawing.Point(26, 258);
            this.IleLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.IleLabel.Name = "IleLabel";
            this.IleLabel.Size = new System.Drawing.Size(34, 25);
            this.IleLabel.TabIndex = 4;
            this.IleLabel.Text = "Ile";
            // 
            // Ile
            // 
            this.Ile.DecimalPlaces = 2;
            this.Ile.Location = new System.Drawing.Point(204, 258);
            this.Ile.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Ile.Name = "Ile";
            this.Ile.Size = new System.Drawing.Size(240, 31);
            this.Ile.TabIndex = 5;
            // 
            // OpisLabel
            // 
            this.OpisLabel.AutoSize = true;
            this.OpisLabel.Location = new System.Drawing.Point(24, 348);
            this.OpisLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.OpisLabel.Name = "OpisLabel";
            this.OpisLabel.Size = new System.Drawing.Size(56, 25);
            this.OpisLabel.TabIndex = 6;
            this.OpisLabel.Text = "Opis";
            // 
            // Opis
            // 
            this.Opis.Location = new System.Drawing.Point(204, 365);
            this.Opis.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Opis.Name = "Opis";
            this.Opis.Size = new System.Drawing.Size(468, 166);
            this.Opis.TabIndex = 7;
            this.Opis.Text = "";
            // 
            // Dodaj
            // 
            this.Dodaj.Location = new System.Drawing.Point(36, 650);
            this.Dodaj.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Dodaj.Name = "Dodaj";
            this.Dodaj.Size = new System.Drawing.Size(150, 44);
            this.Dodaj.TabIndex = 8;
            this.Dodaj.Text = "Dodaj";
            this.Dodaj.UseVisualStyleBackColor = true;
            this.Dodaj.Click += new System.EventHandler(this.Dodaj_Click);
            // 
            // Rozliczone
            // 
            this.Rozliczone.AutoSize = true;
            this.Rozliczone.Location = new System.Drawing.Point(36, 606);
            this.Rozliczone.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Rozliczone.Name = "Rozliczone";
            this.Rozliczone.Size = new System.Drawing.Size(150, 29);
            this.Rozliczone.TabIndex = 9;
            this.Rozliczone.Text = "Rozliczone";
            this.Rozliczone.UseVisualStyleBackColor = true;
            // 
            // EditLabel
            // 
            this.EditLabel.AutoSize = true;
            this.EditLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditLabel.Location = new System.Drawing.Point(26, 25);
            this.EditLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.EditLabel.Name = "EditLabel";
            this.EditLabel.Size = new System.Drawing.Size(403, 37);
            this.EditLabel.TabIndex = 10;
            this.EditLabel.Text = "Dodaj/Modyfikuj rozliczenie";
            // 
            // AddNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.EditLabel);
            this.Controls.Add(this.Rozliczone);
            this.Controls.Add(this.Dodaj);
            this.Controls.Add(this.Opis);
            this.Controls.Add(this.OpisLabel);
            this.Controls.Add(this.Ile);
            this.Controls.Add(this.IleLabel);
            this.Controls.Add(this.KomuCombo);
            this.Controls.Add(this.KomuLabel);
            this.Controls.Add(this.KtoLabel);
            this.Controls.Add(this.KtoCombo);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "AddNew";
            this.Text = "AddNew";
            ((System.ComponentModel.ISupportInitialize)(this.Ile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox KtoCombo;
        private System.Windows.Forms.Label KtoLabel;
        private System.Windows.Forms.Label KomuLabel;
        private System.Windows.Forms.ComboBox KomuCombo;
        private System.Windows.Forms.Label IleLabel;
        private System.Windows.Forms.NumericUpDown Ile;
        private System.Windows.Forms.Label OpisLabel;
        private System.Windows.Forms.RichTextBox Opis;
        private System.Windows.Forms.Button Dodaj;
        private System.Windows.Forms.CheckBox Rozliczone;
        private System.Windows.Forms.Label EditLabel;
    }
}