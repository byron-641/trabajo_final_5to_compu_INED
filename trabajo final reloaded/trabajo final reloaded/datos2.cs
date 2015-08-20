using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace trabajo_final_reloaded
{
    public partial class datos2 : Form
    {
        public datos2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection miconexion = new OleDbConnection(conexion.conn);
            OleDbCommand guardar = new OleDbCommand("insert INTO alumno (Id, nombre1, nombre2, apellido1, apellido2, clave, orientacion)values (@Id, @nombre1, @nombre2, @apellido1, @apellido2, @clave, @orientacion)", miconexion);
            guardar.Parameters.AddWithValue("Id", textBox1.Text);
            guardar.Parameters.AddWithValue("nombre1", textBox2.Text);
            guardar.Parameters.AddWithValue("nombre2", textBox3.Text);
            guardar.Parameters.AddWithValue("apellido1", textBox4.Text);
            guardar.Parameters.AddWithValue("Id", textBox5.Text);
            guardar.Parameters.AddWithValue("Id", textBox6.Text);
            guardar.Parameters.AddWithValue("Id", textBox7.Text);
            miconexion.Open();
            guardar.ExecuteNonQuery();
            MessageBox.Show("Guardado con exito");
            miconexion.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection miconexion = new OleDbConnection(conexion.conn);
            OleDbCommand actualizar = new OleDbCommand("update INTO alumno (Id, nombre1, nombre2, apellido1, apellido2, clave, orientacion)values (@Id, @nombre1, @nombre2, @apellido1, @apellido2, @clave, @orientacion)", miconexion);
            actualizar.Parameters.AddWithValue("Id", textBox1.Text);
            actualizar.Parameters.AddWithValue("nombre1", textBox2.Text);
            actualizar.Parameters.AddWithValue("nombre2", textBox3.Text);
            actualizar.Parameters.AddWithValue("apellido1", textBox4.Text);
            actualizar.Parameters.AddWithValue("Id", textBox5.Text);
            actualizar.Parameters.AddWithValue("Id", textBox6.Text);
            actualizar.Parameters.AddWithValue("Id", textBox7.Text);
            miconexion.Open();
            actualizar.ExecuteNonQuery();
            MessageBox.Show("Guardado con exito");
            miconexion.Close();
        }
    }
}
