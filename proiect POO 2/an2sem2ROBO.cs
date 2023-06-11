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
    public partial class an2sem2ROBO : UserControl
    {
        public an2sem2ROBO()
        {
            InitializeComponent();
            fillGridView();
        }
        void fillGridView()
        {
            dataGridView1.Rows.Add("1", "Mecanisme si organe de masini", "MOM", "5");
            dataGridView1.Rows.Add("2", "Mecanica fluidelor", "MF", "2");
            dataGridView1.Rows.Add("3", "Arhitectura calculatoarelor numerice", "ACN", "5");
            dataGridView1.Rows.Add("4", "Electronica digitala", "ED", "3");
            dataGridView1.Rows.Add("5", "Teoria sistemelor 2", "TS 2", "3");
            dataGridView1.Rows.Add("6", "Rezistenta materialelor", "RM", "3");
            dataGridView1.Rows.Add("7", "Microcontrolere si microprocesoare", "MM", "3");

        }
    }
}
