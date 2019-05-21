namespace Dolce
{
    partial class Main
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.AddNew = new System.Windows.Forms.Button();
            this.Recent = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Komu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rozliczone = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Refresh = new System.Windows.Forms.Button();
            this.Generate = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.daneBaza = new Dolce.DaneBaza();
            ((System.ComponentModel.ISupportInitialize)(this.Recent)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daneBaza)).BeginInit();
            this.SuspendLayout();
            // 
            // AddNew
            // 
            this.AddNew.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddNew.Location = new System.Drawing.Point(0, 0);
            this.AddNew.Margin = new System.Windows.Forms.Padding(6);
            this.AddNew.Name = "AddNew";
            this.AddNew.Size = new System.Drawing.Size(232, 46);
            this.AddNew.TabIndex = 0;
            this.AddNew.Text = "Add";
            this.AddNew.UseVisualStyleBackColor = true;
            this.AddNew.Click += new System.EventHandler(this.AddNew_Click);
            // 
            // Recent
            // 
            this.Recent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Recent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Recent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Ile,
            this.Opis,
            this.Kto,
            this.Komu,
            this.Rozliczone});
            this.Recent.Location = new System.Drawing.Point(6, 92);
            this.Recent.Margin = new System.Windows.Forms.Padding(6);
            this.Recent.Name = "Recent";
            this.Recent.ReadOnly = true;
            this.Recent.RowHeadersWidth = 82;
            this.Recent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Recent.Size = new System.Drawing.Size(1358, 792);
            this.Recent.TabIndex = 1;
            this.Recent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Recent_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 10;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Ile
            // 
            this.Ile.HeaderText = "Ile";
            this.Ile.MinimumWidth = 10;
            this.Ile.Name = "Ile";
            this.Ile.ReadOnly = true;
            // 
            // Opis
            // 
            this.Opis.HeaderText = "Opis";
            this.Opis.MinimumWidth = 10;
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            // 
            // Kto
            // 
            this.Kto.HeaderText = "Kto";
            this.Kto.MinimumWidth = 10;
            this.Kto.Name = "Kto";
            this.Kto.ReadOnly = true;
            // 
            // Komu
            // 
            this.Komu.HeaderText = "Komu";
            this.Komu.MinimumWidth = 10;
            this.Komu.Name = "Komu";
            this.Komu.ReadOnly = true;
            // 
            // Rozliczone
            // 
            this.Rozliczone.HeaderText = "Rozliczone";
            this.Rozliczone.MinimumWidth = 10;
            this.Rozliczone.Name = "Rozliczone";
            this.Rozliczone.ReadOnly = true;
            this.Rozliczone.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Rozliczone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Refresh);
            this.panel1.Controls.Add(this.Generate);
            this.panel1.Controls.Add(this.Delete);
            this.panel1.Controls.Add(this.Edit);
            this.panel1.Controls.Add(this.AddNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 890);
            this.panel1.TabIndex = 3;
            // 
            // Refresh
            // 
            this.Refresh.Dock = System.Windows.Forms.DockStyle.Top;
            this.Refresh.Location = new System.Drawing.Point(0, 178);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(232, 44);
            this.Refresh.TabIndex = 4;
            this.Refresh.Text = "Odśwież";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Generate
            // 
            this.Generate.Dock = System.Windows.Forms.DockStyle.Top;
            this.Generate.Location = new System.Drawing.Point(0, 134);
            this.Generate.Margin = new System.Windows.Forms.Padding(6);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(232, 44);
            this.Generate.TabIndex = 3;
            this.Generate.Text = "Generuj Rozliczenie";
            this.Generate.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            this.Delete.Dock = System.Windows.Forms.DockStyle.Top;
            this.Delete.Location = new System.Drawing.Point(0, 90);
            this.Delete.Margin = new System.Windows.Forms.Padding(6);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(232, 44);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // Edit
            // 
            this.Edit.Dock = System.Windows.Forms.DockStyle.Top;
            this.Edit.Location = new System.Drawing.Point(0, 46);
            this.Edit.Margin = new System.Windows.Forms.Padding(6);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(232, 44);
            this.Edit.TabIndex = 1;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TitleLabel.Location = new System.Drawing.Point(6, 0);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(1358, 86);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Dolce";
            this.TitleLabel.Click += new System.EventHandler(this.TitleLabel_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.TitleLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Recent, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(232, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.719222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.28078F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1370, 890);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.daneBaza;
            this.bindingSource1.Position = 0;
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.BindingSource1_CurrentChanged);
            // 
            // daneBaza
            // 
            this.daneBaza.DataSetName = "DaneBaza";
            this.daneBaza.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1602, 890);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Main";
            this.Text = "Dolce";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Recent)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daneBaza)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddNew;
        private System.Windows.Forms.DataGridView Recent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DaneBaza daneBaza;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Komu;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Rozliczone;
    }
}

