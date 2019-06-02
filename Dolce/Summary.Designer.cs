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
            this.label4 = new System.Windows.Forms.Label();
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
            this.label2.Location = new System.Drawing.Point(695, 70);
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
            this.Osoba1Combo.Size = new System.Drawing.Size(121, 33);
            this.Osoba1Combo.TabIndex = 2;
            // 
            // Osoba2Combo
            // 
            this.Osoba2Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Osoba2Combo.FormattingEnabled = true;
            this.Osoba2Combo.Location = new System.Drawing.Point(700, 161);
            this.Osoba2Combo.Name = "Osoba2Combo";
            this.Osoba2Combo.Size = new System.Drawing.Size(121, 33);
            this.Osoba2Combo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 522);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Należność";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 521);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "<hajs>";
            // 
            // LiczButton
            // 
            this.LiczButton.Location = new System.Drawing.Point(56, 276);
            this.LiczButton.Name = "LiczButton";
            this.LiczButton.Size = new System.Drawing.Size(128, 44);
            this.LiczButton.TabIndex = 6;
            this.LiczButton.Text = "Licz";
            this.LiczButton.UseVisualStyleBackColor = true;
            // 
            // Summary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 892);
            this.Controls.Add(this.LiczButton);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button LiczButton;
    }
}