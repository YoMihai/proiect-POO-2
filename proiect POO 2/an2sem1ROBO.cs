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
    public partial class an2sem1ROBO : UserControl
    {
        public an2sem1ROBO()
        {
            InitializeComponent();
            fillGridView();
        }
        void fillGridView()
        {
            dataGridView1.Rows.Add("1", "Bazele roboticii", "BRobo", "5");
            dataGridView1.Rows.Add("2", "Electronica", "EL", "5");
            dataGridView1.Rows.Add("3", "Teoria sistemelor 1", "TS 1", "5");
            dataGridView1.Rows.Add("4", "Metode numerice", "MN", "4");
            dataGridView1.Rows.Add("5", "Programare in java", "Java", "4");

        }
    }
}
