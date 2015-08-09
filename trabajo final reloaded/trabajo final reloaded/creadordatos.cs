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
    public partial class creadordatos : Form
    {
        public creadordatos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
                {
                    OleDbConnection miconeccion = new OleDbConnection(coneccion.con);
                    OleDbCommand cguardar = new OleDbCommand("insert into planillas(Id,clave,nombre1,nombre2,apellido1,apellido2,grado,orientacion)values(@Id,@clave,@nombre1,@nombre2,@apellido1,@apellido2,@grado,@orientacion)", miconeccion) ;
                    cguardar.Parameters.AddWithValue("nombre1",textBox1.Text);
                    cguardar.Parameters.AddWithValue("nombre2", textBox2.Text);
                    cguardar.Parameters.AddWithValue("apellido1", textBox3.Text);
                    cguardar.Parameters.AddWithValue("apellido2", textBox4.Text);
                    cguardar.Parameters.AddWithValue("Id", textBox5.Text);
                    cguardar.Parameters.AddWithValue("orientacion", textBox6.Text);
                    miconeccion.Open();
                    cguardar.ExecuteNonQuery();
                    administrador administrador = new administrador();
                    administrador.Show();
                    MessageBox.Show("Datos Guardados Exitosamente","Informacion del Sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    miconeccion.Close();
                    this.Hide();
                
                }
            catch (Exception)
                 {
                     MessageBox.Show("mula");
                
                 }
            
        }
    }
}
