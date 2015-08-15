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
            seleccionalumno seleccion_alumno = new seleccionalumno();
            login login = new login();
            seleccion_alumno.Show();
            this.Hide();
            
            
            
        }
        
      

       
        private void button2_Click(object sender, EventArgs e)
        {
            editor editor = new editor();
            editor.Show();
            
            
            
            
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            seleccionaver seleccionaver = new seleccionaver();
            seleccionaver.Show();
            
        }

        private void administrador_Load(object sender, EventArgs e)
        {

        }
    }
}
