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
using Tapanyagok.ViewInterfaces;

namespace Tapanyagok.Views
{
    public partial class TapanyagForm : Form, ITapanyagView
    {
        private int id;
        public TapanyagForm()
        {
            InitializeComponent();
        }

        public tapanyag tapanyag {
            get 
            {
                var ujTapanyag = new tapanyag(
                        textBoxNev.Text, 
                        numericUpDownEnergia.Value, 
                        numericUpDownFeherje.Value, 
                        numericUpDownZsir.Value, 
                        numericUpDownSzenhidrat.Value
                        );
                if (id>0)
                {
                    ujTapanyag.id = id;
                }
                return ujTapanyag;

            }
            set 
            {
                id = value.id;
                textBoxNev.Text = value.nev;
                numericUpDownEnergia.Value = value.energia;
                numericUpDownFeherje.Value = value.feherje;
                numericUpDownZsir.Value = value.zsir;
                numericUpDownSzenhidrat.Value = value.szenhidrat;
            } 
        }
    }
}
