using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect_POO_2
{
    public partial class anul22 : UserControl
    {

        public anul22()
        {
            InitializeComponent();
            fillGridView();
        }

        void fillGridView()
        {
            dataGridView1.Rows.Add("1", "Teoria sistemelor 2", "TS2", "5");
            dataGridView1.Rows.Add("2", "Electronica digitala", "ED", "4");
            dataGridView1.Rows.Add("3", "Programare orientata pe obiecte", "POO", "4");
            dataGridView1.Rows.Add("4", "Prelucrarea semnalelor", "PS", "3");
            dataGridView1.Rows.Add("5", "Sisteme automate cu esantionare", "SAE", "4");
            dataGridView1.Rows.Add("6", "Analiza si sinteza circuitelor numerice 1", "ASCN 1", "5");
        }

    }
}
