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
    public partial class an2sem2TI : UserControl
    {
        public an2sem2TI()
        {
            InitializeComponent();
            fillGridView();
        }
        void fillGridView()
        {
            dataGridView1.Rows.Add("1", "Proiectarea algoritmilor", "PA", "4");
            dataGridView1.Rows.Add("2", "Electronica digitala", "ED", "5");
            dataGridView1.Rows.Add("3", "Programarea calculatoarelor si limbaje de programare 3", "PCLP 3", "4");
            dataGridView1.Rows.Add("4", "Elemente de grafica pe calculator", "EGC", "5");
            dataGridView1.Rows.Add("5", "Programare logica si programare functionala", "PLF", "2");

        }
    }
}
