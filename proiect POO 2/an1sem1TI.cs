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
    public partial class an1sem1TI : UserControl
    {
        public an1sem1TI()
        {
            InitializeComponent();
            fillGridView();
        }
        void fillGridView()
        {
            dataGridView1.Rows.Add("1", "Introducere in calculatoare si tehnologia informatiei", "ICTI", "4");
            dataGridView1.Rows.Add("2", "Comunicare", "ET", "6");
            dataGridView1.Rows.Add("3", "Programarea calculatoarelor si limbaje de programare 1", "PCLP 1", "5");
            dataGridView1.Rows.Add("4", "Grafica asistata de calculator", "GAC", "4");
            dataGridView1.Rows.Add("5", "Algebra liniara, geometrie analitica si diferentiala", "ALGAD", "4");
        }
    }
}
