namespace Tapanyagok
{
    partial class MainForm
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
            this.textBoxSearchText = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tapanyagBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nevDataGridViewTextBoxColumn,
            this.energiaDataGridViewTextBoxColumn,
            this.feherjeDataGridViewTextBoxColumn,
            this.zsirDataGridViewTextBoxColumn,
            this.szenhidratDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tapanyagBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 39);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
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
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nevDataGridViewTextBoxColumn
            // 
            this.nevDataGridViewTextBoxColumn.DataPropertyName = "nev";
            this.nevDataGridViewTextBoxColumn.HeaderText = "nev";
            this.nevDataGridViewTextBoxColumn.Name = "nevDataGridViewTextBoxColumn";
            this.nevDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // energiaDataGridViewTextBoxColumn
            // 
            this.energiaDataGridViewTextBoxColumn.DataPropertyName = "energia";
            this.energiaDataGridViewTextBoxColumn.HeaderText = "energia";
            this.energiaDataGridViewTextBoxColumn.Name = "energiaDataGridViewTextBoxColumn";
            this.energiaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // feherjeDataGridViewTextBoxColumn
            // 
            this.feherjeDataGridViewTextBoxColumn.DataPropertyName = "feherje";
            this.feherjeDataGridViewTextBoxColumn.HeaderText = "feherje";
            this.feherjeDataGridViewTextBoxColumn.Name = "feherjeDataGridViewTextBoxColumn";
            this.feherjeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zsirDataGridViewTextBoxColumn
            // 
            this.zsirDataGridViewTextBoxColumn.DataPropertyName = "zsir";
            this.zsirDataGridViewTextBoxColumn.HeaderText = "zsir";
            this.zsirDataGridViewTextBoxColumn.Name = "zsirDataGridViewTextBoxColumn";
            this.zsirDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // szenhidratDataGridViewTextBoxColumn
            // 
            this.szenhidratDataGridViewTextBoxColumn.DataPropertyName = "szenhidrat";
            this.szenhidratDataGridViewTextBoxColumn.HeaderText = "szenhidrat";
            this.szenhidratDataGridViewTextBoxColumn.Name = "szenhidratDataGridViewTextBoxColumn";
            this.szenhidratDataGridViewTextBoxColumn.ReadOnly = true;
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
            // textBoxSearchText
            // 
            this.textBoxSearchText.Location = new System.Drawing.Point(12, 12);
            this.textBoxSearchText.Name = "textBoxSearchText";
            this.textBoxSearchText.Size = new System.Drawing.Size(340, 20);
            this.textBoxSearchText.TabIndex = 3;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(358, 10);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Keresés";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(439, 10);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Törlés";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearchText);
            this.Controls.Add(this.pageLabel);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tapanyagBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox textBoxSearchText;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonDelete;
    }
}

