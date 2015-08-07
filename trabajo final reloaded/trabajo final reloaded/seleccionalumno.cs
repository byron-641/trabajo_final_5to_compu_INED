using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabajo_final_reloaded
{
    public partial class seleccionalumno : Form
    {
        public seleccionalumno()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            creadordatos creadordatos = new creadordatos();
            creadordatos.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            escoger_3 escoger_3 = new escoger_3();
            escoger_3.Show();
            
            
        



            
        }
       


        
    }
}
