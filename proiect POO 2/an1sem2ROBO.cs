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
    public partial class an1sem2ROBO : UserControl
    {
        public an1sem2ROBO()
        {
            InitializeComponent();
            fillGridView();
        }
        void fillGridView()
        {
            dataGridView1.Rows.Add("1", "Dinamica sistemelor", "DS", "4");
            dataGridView1.Rows.Add("2", "Informatica aplicata", "IA", "5");
            dataGridView1.Rows.Add("3", "Matematici speciale", "MS", "5");
            dataGridView1.Rows.Add("4", "Electrotehnica", "ET", "6");
            dataGridView1.Rows.Add("5", "Fizica", "FIZ", "4");
            dataGridView1.Rows.Add("6", "Grafica asistata pe calculator", "GAC", "4");

        }
    }
}
