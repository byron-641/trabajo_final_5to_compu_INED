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
        public static string con = @"C:\Users\GGM3\Documents\GitHub\trabajo_final_5to_compu_INED\trabajo final reloaded\trabajo final reloaded\proyecto_final.accdb";
        public creadordatos()
        {

            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
                {
                    OleDbConnection miconeccion = new OleDbConnection(con);
                    OleDbCommand cguardar = new OleDbCommand("insert into datosalumno(Id,nombre1,nombre2,apellido1,apellido2,clave,orientacion)values(@Id,@nombre1,@nombre2,@apellido1,@apellido2,@clave,@orientacion)", miconeccion);
                    OleDbDataReader reader;
                    miconeccion.Open();
                    
                    cguardar.Parameters.AddWithValue("Id",textBox7.Text);
                    cguardar.Parameters.AddWithValue("nombre1",textBox1.Text);
                    cguardar.Parameters.AddWithValue("nombre2", textBox2.Text);
                    cguardar.Parameters.AddWithValue("apellido1", textBox3.Text);
                    cguardar.Parameters.AddWithValue("apellido2", textBox4.Text);
                    
                    cguardar.Parameters.AddWithValue("orientacion", textBox6.Text);
                    
                    
                    cguardar.ExecuteNonQuery();
                    MessageBox.Show("Datos Guardados Exitosamente","Informacion del Sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    miconeccion.Close();
                    administrador administrador = new administrador();
                    administrador.Show();
                    this.Hide();
                
                }
            catch (Exception)
                 {
                     MessageBox.Show("mula");
                
                 }
            
        }

        private void creadordatos_Load(object sender, EventArgs e)
        {
            
        }
    }
}
