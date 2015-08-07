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
        validar v = new validar();
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
            
            if (textBox1.Text=="admin"&& double.Parse(textBox2.Text)==1234)
            {
                MessageBox.Show("Bienvenido Administrador");
                this.Hide();
                administrador administrador = new administrador();
                administrador.Show();

            }
            if (textBox1.Text == "maestro" && double.Parse(textBox2.Text) == 1243)
            {
                MessageBox.Show("Bienvenido Maestro");
                this.Hide();
                maestro maestro = new maestro();
                maestro.Show();

            }
            if (textBox1.Text == "alumno" && double.Parse(textBox2.Text) == 1212)
            {
                MessageBox.Show("Bienvenido Alumno");
                this.Hide();
                seleccionaver seleccionaver = new seleccionaver();
                seleccionaver.Show();

            }

           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }
        
    }
}
