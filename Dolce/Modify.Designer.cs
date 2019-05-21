namespace Dolce
{
    partial class Modify
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
            this.ModifyLabel = new System.Windows.Forms.Label();
            this.KtoLabelEdytuj = new System.Windows.Forms.Label();
            this.KtoLabelEdytujDb = new System.Windows.Forms.Label();
            this.KomuLabelEdytuj = new System.Windows.Forms.Label();
            this.KomuLabelEdytujDb = new System.Windows.Forms.Label();
            this.IleLabelEdytuj = new System.Windows.Forms.Label();
            this.ileEdytujDb = new System.Windows.Forms.NumericUpDown();
            this.IdLabelEdytuj = new System.Windows.Forms.Label();
            this.IdLabelEdytujDb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ileEdytujDb)).BeginInit();
            this.SuspendLayout();
            // 
            // ModifyLabel
            // 
            this.ModifyLabel.AutoSize = true;
            this.ModifyLabel.Location = new System.Drawing.Point(44, 54);
            this.ModifyLabel.Name = "ModifyLabel";
            this.ModifyLabel.Size = new System.Drawing.Size(213, 25);
            this.ModifyLabel.TabIndex = 0;
            this.ModifyLabel.Text = "Modyfikuj rozliczenie";
            // 
            // KtoLabelEdytuj
            // 
            this.KtoLabelEdytuj.AutoSize = true;
            this.KtoLabelEdytuj.Location = new System.Drawing.Point(44, 161);
            this.KtoLabelEdytuj.Name = "KtoLabelEdytuj";
            this.KtoLabelEdytuj.Size = new System.Drawing.Size(44, 25);
            this.KtoLabelEdytuj.TabIndex = 1;
            this.KtoLabelEdytuj.Text = "Kto";
            // 
            // KtoLabelEdytujDb
            // 
            this.KtoLabelEdytujDb.AutoSize = true;
            this.KtoLabelEdytujDb.Location = new System.Drawing.Point(174, 161);
            this.KtoLabelEdytujDb.Name = "KtoLabelEdytujDb";
            this.KtoLabelEdytujDb.Size = new System.Drawing.Size(70, 25);
            this.KtoLabelEdytujDb.TabIndex = 2;
            this.KtoLabelEdytujDb.Text = "label3";
            // 
            // KomuLabelEdytuj
            // 
            this.KomuLabelEdytuj.AutoSize = true;
            this.KomuLabelEdytuj.Location = new System.Drawing.Point(44, 232);
            this.KomuLabelEdytuj.Name = "KomuLabelEdytuj";
            this.KomuLabelEdytuj.Size = new System.Drawing.Size(67, 25);
            this.KomuLabelEdytuj.TabIndex = 3;
            this.KomuLabelEdytuj.Text = "Komu";
            // 
            // KomuLabelEdytujDb
            // 
            this.KomuLabelEdytujDb.AutoSize = true;
            this.KomuLabelEdytujDb.Location = new System.Drawing.Point(174, 232);
            this.KomuLabelEdytujDb.Name = "KomuLabelEdytujDb";
            this.KomuLabelEdytujDb.Size = new System.Drawing.Size(70, 25);
            this.KomuLabelEdytujDb.TabIndex = 4;
            this.KomuLabelEdytujDb.Text = "label5";
            // 
            // IleLabelEdytuj
            // 
            this.IleLabelEdytuj.AutoSize = true;
            this.IleLabelEdytuj.Location = new System.Drawing.Point(49, 294);
            this.IleLabelEdytuj.Name = "IleLabelEdytuj";
            this.IleLabelEdytuj.Size = new System.Drawing.Size(34, 25);
            this.IleLabelEdytuj.TabIndex = 5;
            this.IleLabelEdytuj.Text = "Ile";
            // 
            // ileEdytujDb
            // 
            this.ileEdytujDb.Location = new System.Drawing.Point(169, 304);
            this.ileEdytujDb.Name = "ileEdytujDb";
            this.ileEdytujDb.Size = new System.Drawing.Size(120, 31);
            this.ileEdytujDb.TabIndex = 6;
            // 
            // IdLabelEdytuj
            // 
            this.IdLabelEdytuj.AutoSize = true;
            this.IdLabelEdytuj.Location = new System.Drawing.Point(44, 100);
            this.IdLabelEdytuj.Name = "IdLabelEdytuj";
            this.IdLabelEdytuj.Size = new System.Drawing.Size(32, 25);
            this.IdLabelEdytuj.TabIndex = 7;
            this.IdLabelEdytuj.Text = "ID";
            // 
            // IdLabelEdytujDb
            // 
            this.IdLabelEdytujDb.AutoSize = true;
            this.IdLabelEdytujDb.Location = new System.Drawing.Point(169, 100);
            this.IdLabelEdytujDb.Name = "IdLabelEdytujDb";
            this.IdLabelEdytujDb.Size = new System.Drawing.Size(56, 25);
            this.IdLabelEdytujDb.TabIndex = 8;
            this.IdLabelEdytujDb.Text = "<ID>";
            // 
            // Modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 823);
            this.Controls.Add(this.IdLabelEdytujDb);
            this.Controls.Add(this.IdLabelEdytuj);
            this.Controls.Add(this.ileEdytujDb);
            this.Controls.Add(this.IleLabelEdytuj);
            this.Controls.Add(this.KomuLabelEdytujDb);
            this.Controls.Add(this.KomuLabelEdytuj);
            this.Controls.Add(this.KtoLabelEdytujDb);
            this.Controls.Add(this.KtoLabelEdytuj);
            this.Controls.Add(this.ModifyLabel);
            this.Name = "Modify";
            this.Text = "Modify";
            ((System.ComponentModel.ISupportInitialize)(this.ileEdytujDb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ModifyLabel;
        private System.Windows.Forms.Label KtoLabelEdytuj;
        private System.Windows.Forms.Label KtoLabelEdytujDb;
        private System.Windows.Forms.Label KomuLabelEdytuj;
        private System.Windows.Forms.Label KomuLabelEdytujDb;
        private System.Windows.Forms.Label IleLabelEdytuj;
        private System.Windows.Forms.NumericUpDown ileEdytujDb;
        private System.Windows.Forms.Label IdLabelEdytuj;
        private System.Windows.Forms.Label IdLabelEdytujDb;
    }
}