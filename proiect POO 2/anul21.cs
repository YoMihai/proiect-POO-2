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
    public partial class anul21 : UserControl
    {

        public anul21()
        {
            InitializeComponent();
            fillGridView();
        }

        void fillGridView()
        {
            dataGridView1.Rows.Add("1", "Teoria sistemelor 1", "TS 1", "6");
            dataGridView1.Rows.Add("2", "Robotica", "Robo", "5");
            dataGridView1.Rows.Add("3", "Circuite electronice liniare", "CEL", "5");
            dataGridView1.Rows.Add("4", "Metode numerice", "MN", "4");
            dataGridView1.Rows.Add("5", "Masurari si traductoare", "MT", "4");
            dataGridView1.Rows.Add("6", "Proiectarea algoritmilor", "PA", "4");
        }

    }
}
