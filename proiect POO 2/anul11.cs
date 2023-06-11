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
    public partial class anul11 : UserControl
    {


        public anul11()
        {
            InitializeComponent();
            fillGridView();
        }
        void fillGridView()
        {
            dataGridView1.Rows.Add("1", "Analiza matematica", "AM", "6");
            dataGridView1.Rows.Add("2", "Algebra liniara,geometrie analitica si diferentiala", "ALGAD", "6");
            dataGridView1.Rows.Add("3", "Programarea calculatoarelor si limbaje de programare 1", "PCLP 1", "6");
            dataGridView1.Rows.Add("4", "Logica computationala", "LC", "4");
            dataGridView1.Rows.Add("5", "Tehnologii Web", "TWeb", "3");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
