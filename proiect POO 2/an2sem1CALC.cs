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
    public partial class an2sem1CALC : UserControl
    {
        public an2sem1CALC()
        {
            InitializeComponent();
            fillGridView();
        }
        void fillGridView()
        {
            dataGridView1.Rows.Add("1", "Teoria sistemelor", "TS", "6");
            dataGridView1.Rows.Add("2", "Masurari electronice", "ME", "5");
            dataGridView1.Rows.Add("3", "Dispozitive electronice", "DE", "5");
            dataGridView1.Rows.Add("4", "Structuri de date si algoritmi", "SDA", "6");
            dataGridView1.Rows.Add("5", "Procesarea semnalelor", "PS", "6");

        }
    }
}
