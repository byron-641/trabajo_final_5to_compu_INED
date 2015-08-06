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
    
    public partial class login : Form
    {
        public login()

        {
            InitializeComponent();

        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string usuario, contraseña;
            usuario = textBox1.Text;
            contraseña = textBox2.Text;
            if ((usuario=="admin")&&(contraseña=="1234"))
            {
                forms.administrador.Show();
                
            }
            if ((usuario == "maestro") && (contraseña == "123"))
            {
                forms.maestro.Show();

            }
            if ((usuario == "alumno") && (contraseña == "12"))
            {
                forms.seleccionaver.Show();

            }
            else
            {
                

            }

        }
    }
}
