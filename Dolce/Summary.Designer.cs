namespace Dolce
{
    partial class Summary
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Osoba1Combo = new System.Windows.Forms.ComboBox();
            this.Osoba2Combo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IleHajsu = new System.Windows.Forms.Label();
            this.LiczButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Osoba 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(549, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Osoba 2";
            // 
            // Osoba1Combo
            // 
            this.Osoba1Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Osoba1Combo.FormattingEnabled = true;
            this.Osoba1Combo.Location = new System.Drawing.Point(56, 161);
            this.Osoba1Combo.Name = "Osoba1Combo";
            this.Osoba1Combo.Size = new System.Drawing.Size(405, 33);
            this.Osoba1Combo.TabIndex = 2;
            // 
            // Osoba2Combo
            // 
            this.Osoba2Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Osoba2Combo.FormattingEnabled = true;
            this.Osoba2Combo.Location = new System.Drawing.Point(543, 161);
            this.Osoba2Combo.Name = "Osoba2Combo";
            this.Osoba2Combo.Size = new System.Drawing.Size(420, 33);
            this.Osoba2Combo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Należność";
            // 
            // IleHajsu
            // 
            this.IleHajsu.AutoSize = true;
            this.IleHajsu.Location = new System.Drawing.Point(223, 380);
            this.IleHajsu.Name = "IleHajsu";
            this.IleHajsu.Size = new System.Drawing.Size(76, 25);
            this.IleHajsu.TabIndex = 5;
            this.IleHajsu.Text = "<hajs>";
            // 
            // LiczButton
            // 
            this.LiczButton.Location = new System.Drawing.Point(56, 276);
            this.LiczButton.Name = "LiczButton";
            this.LiczButton.Size = new System.Drawing.Size(128, 44);
            this.LiczButton.TabIndex = 6;
            this.LiczButton.Text = "Licz";
            this.LiczButton.UseVisualStyleBackColor = true;
            this.LiczButton.Click += new System.EventHandler(this.LiczButton_Click);
            // 
            // Summary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 450);
            this.Controls.Add(this.LiczButton);
            this.Controls.Add(this.IleHajsu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Osoba2Combo);
            this.Controls.Add(this.Osoba1Combo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Summary";
            this.Text = "Summary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Osoba1Combo;
        private System.Windows.Forms.ComboBox Osoba2Combo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label IleHajsu;
        private System.Windows.Forms.Button LiczButton;
    }
}