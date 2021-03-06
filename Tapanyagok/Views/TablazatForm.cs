﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tapanyagok.Models;
using Tapanyagok.Presenters;
using Tapanyagok.ViewInterfaces;
using Tapanyagok.Views;

namespace Tapanyagok
{
    public partial class TablazatForm : Form, ITablazatView
    {
        private TablazatPresenter presenter;
        private int pageCount;
        private int colIndex;
        private tapanyag selectedItem;



        public TablazatForm()
        {
            InitializeComponent();
            presenter = new TablazatPresenter(this);
            Init();
        }

        public void Init()
        {
            pageNumber = 1;
            itemsPerPage = 10;
            sortBy = "id";
            ascending = true;
            colIndex = 0;
        }
                
        public BindingList<tapanyag> bindingList { 
            get => (BindingList<tapanyag>)dataGridView1.DataSource; 
            set => dataGridView1.DataSource = value; }
        public int pageNumber { get; set; }
        public int itemsPerPage { get; set; }
        public string search => toolStripTextBoxSearchText.Text;
        public string sortBy { get; set; }
        public bool ascending { get; set; }
        public int totalitems 
        {
            set
            {
                pageCount = ((value - 1) / itemsPerPage) + 1;
                pageLabel.Text = pageNumber.ToString() + " / " + pageCount.ToString();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            presenter.LoadData();
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            pageNumber = 1;
            presenter.LoadData();
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            if (pageNumber >= 2)
            {
                pageNumber--;
                presenter.LoadData();
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (pageNumber < pageCount)
            {
                pageNumber++;
                presenter.LoadData();
            }
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            pageNumber = pageCount;
            presenter.LoadData();
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (colIndex == e.ColumnIndex)
            {
                ascending = !ascending;
            }

            switch (e.ColumnIndex)
            {
                default:
                    sortBy = "id";
                    break;
                case 1:
                    sortBy = "nev";
                    break;
                case 2:
                    sortBy = "energia";
                    break;
                case 3:
                    sortBy = "feherje";
                    break;
                case 4:
                    sortBy = "zsir";
                    break;
                case 5:
                    sortBy = "szenhidrat";
                    break;

            }

            colIndex = e.ColumnIndex;
            presenter.LoadData();
        }
                
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedItem = (tapanyag)dataGridView1.SelectedRows[0].DataBoundItem;
            
        }

        private void toolStripButtonSava_Click(object sender, EventArgs e)
        {
            presenter.Save();
        }

        private void toolStripButtonNew_Click(object sender, EventArgs e)
        {
            using (var szerkForm = new TapanyagForm())
            {
                DialogResult dr = szerkForm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    presenter.Add(szerkForm.tapanyag);
                    szerkForm.Close();
                }
            }
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;                
                presenter.Remove(selectedRowIndex);
            }
            
        }

        private void toolStripButtonSearch_Click(object sender, EventArgs e)
        {
            presenter.LoadData();
        }

        private void toolStripMenuItemModify_Click(object sender, EventArgs e)
        {
            
            var tapa = (tapanyag)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem;

            if (tapa != null)
            {
                int sorIndex = dataGridView1.SelectedRows[0].Index;
                using (var modForm = new TapanyagForm())
                {
                    modForm.tapanyag = tapa;
                    DialogResult dr = modForm.ShowDialog(this);
                    if (dr == DialogResult.OK)
                    {
                        presenter.Modify(sorIndex, modForm.tapanyag);
                        modForm.Close();
                    }
                }
            }
        }
    }
}
