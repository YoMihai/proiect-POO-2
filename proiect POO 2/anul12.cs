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
    public partial class anul12 : UserControl
    {

        public anul12()
        {
            InitializeComponent();
            fillGridView();
        }
        void fillGridView()
        {
            dataGridView1.Rows.Add("1", "Matematici speciale", "MS", "6");
            dataGridView1.Rows.Add("2", "Electrotehnica", "ET", "6");
            dataGridView1.Rows.Add("3", "Programarea calculatoarelor si limbaje de programare 2", "PCLP 2", "5");
            dataGridView1.Rows.Add("4", "Procesarea datelor", "PD", "4");
            dataGridView1.Rows.Add("5", "Fizica", "Fiz", "4");
            dataGridView1.Rows.Add("6", "Grafica asistata pe calculator", "GAC", "4");
        }

    }
}
