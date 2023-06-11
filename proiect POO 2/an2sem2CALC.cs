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
    public partial class an2sem2CALC : UserControl
    {
        public an2sem2CALC()
        {
            InitializeComponent();
            fillGridView();
        }
        void fillGridView()
        {
            dataGridView1.Rows.Add("1", "Limbaje formale si compilatoare", "LFC", "5");
            dataGridView1.Rows.Add("2", "Electronica digitala", "ED", "6");
            dataGridView1.Rows.Add("3", "Electronica analogica", "EA", "5");
            dataGridView1.Rows.Add("4", "Bazele comunicatiilor", "BC", "4");
            dataGridView1.Rows.Add("5", "Proiectarea algoritmilor", "PA", "5");

        }
    }
}
