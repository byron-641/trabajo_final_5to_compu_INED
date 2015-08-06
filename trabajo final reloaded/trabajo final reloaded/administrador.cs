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
    public partial class administrador : Form
    {
        public administrador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            forms.seleccion_alumno.Show();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            editor editor = new editor();
            editor.Show();
            
            
            
            
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            forms.seleccionaver.Show();
            
        }
    }
}
