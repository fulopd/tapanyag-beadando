using System;
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

namespace Tapanyagok
{
    public partial class MainForm : Form, ITapanyagView
    {
        private TapanyagPresenter presenter;
        private int pageCount;
        private int colIndex;
        private tapanyag selectedItem;



        public MainForm()
        {
            InitializeComponent();
            presenter = new TapanyagPresenter(this);
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

        public List<tapanyag> tapanyag { get; set; }
        public BindingList<tapanyag> bindingList { 
            get => (BindingList<tapanyag>)dataGridView1.DataSource; 
            set => dataGridView1.DataSource = value; }
        public int pageNumber { get; set; }
        public int itemsPerPage { get; set; }
        public string search => textBoxSearchText.Text;
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
            presenter.loadData();
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            pageNumber = 1;
            presenter.loadData();
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            if (pageNumber >= 2)
            {
                pageNumber--;
                presenter.loadData();
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (pageNumber < pageCount)
            {
                pageNumber++;
                presenter.loadData();
            }
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            pageNumber = pageCount;
            presenter.loadData();
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
            presenter.loadData();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            presenter.loadData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (selectedItem != null)
            {
                MessageBox.Show("torol");
                presenter.delete(selectedItem);
            }
            presenter.loadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedItem = (tapanyag)dataGridView1.SelectedRows[0].DataBoundItem;
            
        }
    }
}
