namespace Tapanyagok
{
    partial class TablazatForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TablazatForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.energiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feherjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zsirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szenhidratDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tapanyagBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.pageLabel = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSava = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBoxSearchText = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonSearch = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemModify = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemRemove = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tapanyagBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nevDataGridViewTextBoxColumn,
            this.energiaDataGridViewTextBoxColumn,
            this.feherjeDataGridViewTextBoxColumn,
            this.zsirDataGridViewTextBoxColumn,
            this.szenhidratDataGridViewTextBoxColumn});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.DataSource = this.tapanyagBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 39);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(776, 358);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nevDataGridViewTextBoxColumn
            // 
            this.nevDataGridViewTextBoxColumn.DataPropertyName = "nev";
            this.nevDataGridViewTextBoxColumn.HeaderText = "nev";
            this.nevDataGridViewTextBoxColumn.Name = "nevDataGridViewTextBoxColumn";
            // 
            // energiaDataGridViewTextBoxColumn
            // 
            this.energiaDataGridViewTextBoxColumn.DataPropertyName = "energia";
            this.energiaDataGridViewTextBoxColumn.HeaderText = "energia";
            this.energiaDataGridViewTextBoxColumn.Name = "energiaDataGridViewTextBoxColumn";
            // 
            // feherjeDataGridViewTextBoxColumn
            // 
            this.feherjeDataGridViewTextBoxColumn.DataPropertyName = "feherje";
            this.feherjeDataGridViewTextBoxColumn.HeaderText = "feherje";
            this.feherjeDataGridViewTextBoxColumn.Name = "feherjeDataGridViewTextBoxColumn";
            // 
            // zsirDataGridViewTextBoxColumn
            // 
            this.zsirDataGridViewTextBoxColumn.DataPropertyName = "zsir";
            this.zsirDataGridViewTextBoxColumn.HeaderText = "zsir";
            this.zsirDataGridViewTextBoxColumn.Name = "zsirDataGridViewTextBoxColumn";
            // 
            // szenhidratDataGridViewTextBoxColumn
            // 
            this.szenhidratDataGridViewTextBoxColumn.DataPropertyName = "szenhidrat";
            this.szenhidratDataGridViewTextBoxColumn.HeaderText = "szenhidrat";
            this.szenhidratDataGridViewTextBoxColumn.Name = "szenhidratDataGridViewTextBoxColumn";
            // 
            // tapanyagBindingSource
            // 
            this.tapanyagBindingSource.DataSource = typeof(Tapanyagok.Models.tapanyag);
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(196, 415);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(75, 23);
            this.buttonFirst.TabIndex = 1;
            this.buttonFirst.Text = "<<";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(277, 415);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(75, 23);
            this.buttonPrev.TabIndex = 1;
            this.buttonPrev.Text = "<";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(434, 415);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 1;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(515, 415);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(75, 23);
            this.buttonLast.TabIndex = 1;
            this.buttonLast.Text = ">>";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // pageLabel
            // 
            this.pageLabel.AutoSize = true;
            this.pageLabel.Location = new System.Drawing.Point(372, 420);
            this.pageLabel.Name = "pageLabel";
            this.pageLabel.Size = new System.Drawing.Size(30, 13);
            this.pageLabel.TabIndex = 2;
            this.pageLabel.Text = "0 / 0";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSava,
            this.toolStripButtonNew,
            this.toolStripButtonDelete,
            this.toolStripTextBoxSearchText,
            this.toolStripButtonSearch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonSava
            // 
            this.toolStripButtonSava.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSava.Image")));
            this.toolStripButtonSava.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSava.Name = "toolStripButtonSava";
            this.toolStripButtonSava.Size = new System.Drawing.Size(66, 22);
            this.toolStripButtonSava.Text = "Mentés";
            this.toolStripButtonSava.Click += new System.EventHandler(this.toolStripButtonSava_Click);
            // 
            // toolStripButtonNew
            // 
            this.toolStripButtonNew.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNew.Image")));
            this.toolStripButtonNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNew.Name = "toolStripButtonNew";
            this.toolStripButtonNew.Size = new System.Drawing.Size(38, 22);
            this.toolStripButtonNew.Text = "Új";
            this.toolStripButtonNew.Click += new System.EventHandler(this.toolStripButtonNew_Click);
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDelete.Image")));
            this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Size = new System.Drawing.Size(58, 22);
            this.toolStripButtonDelete.Text = "Törlés";
            this.toolStripButtonDelete.Click += new System.EventHandler(this.toolStripButtonDelete_Click);
            // 
            // toolStripTextBoxSearchText
            // 
            this.toolStripTextBoxSearchText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxSearchText.Name = "toolStripTextBoxSearchText";
            this.toolStripTextBoxSearchText.Size = new System.Drawing.Size(150, 25);
            // 
            // toolStripButtonSearch
            // 
            this.toolStripButtonSearch.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSearch.Image")));
            this.toolStripButtonSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSearch.Name = "toolStripButtonSearch";
            this.toolStripButtonSearch.Size = new System.Drawing.Size(66, 22);
            this.toolStripButtonSearch.Text = "Keresés";
            this.toolStripButtonSearch.Click += new System.EventHandler(this.toolStripButtonSearch_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemModify,
            this.toolStripMenuItemRemove});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // toolStripMenuItemModify
            // 
            this.toolStripMenuItemModify.Name = "toolStripMenuItemModify";
            this.toolStripMenuItemModify.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemModify.Text = "Szerkesztes";
            this.toolStripMenuItemModify.Click += new System.EventHandler(this.toolStripMenuItemModify_Click);
            // 
            // toolStripMenuItemRemove
            // 
            this.toolStripMenuItemRemove.Name = "toolStripMenuItemRemove";
            this.toolStripMenuItemRemove.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemRemove.Text = "Törlés";
            this.toolStripMenuItemRemove.Click += new System.EventHandler(this.toolStripButtonDelete_Click);
            // 
            // TablazatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pageLabel);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TablazatForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tapanyagBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn energiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feherjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zsirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn szenhidratDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tapanyagBindingSource;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Label pageLabel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonSava;
        private System.Windows.Forms.ToolStripButton toolStripButtonNew;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxSearchText;
        private System.Windows.Forms.ToolStripButton toolStripButtonSearch;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemModify;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRemove;
    }
}

