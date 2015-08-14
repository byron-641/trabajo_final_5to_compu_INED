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
using Microsoft.VisualBasic;

namespace trabajo_final_reloaded
{
    public partial class editor_datos : Form
    {
        private int actual;
        public editor_datos()
        {

            InitializeComponent();
            actual = getFirstId();
            showData();

        }
        private int getFirstId()
        {
            this.oleDbDataAdapter1.SelectCommand.CommandText = "SELECT * FROM alumno";
            this.oleDbConnection1.Open();
            this.oleDbDataAdapter1.SelectCommand.Connection = oleDbConnection1;

            OleDbDataReader reader = this.oleDbDataAdapter1.SelectCommand.ExecuteReader();
            reader.Read();
            int id = Convert.ToInt16(reader["Id"].ToString());

            this.oleDbConnection1.Close();

            return id;
        }
        private void showData()
        {
            this.oleDbDataAdapter1.SelectCommand.CommandText = "SELECT * FROM alumno WHERE Id =" + actual;
            this.oleDbConnection1.Open();
            this.oleDbDataAdapter1.SelectCommand.Connection = oleDbConnection1;

            OleDbDataReader reader = this.oleDbDataAdapter1.SelectCommand.ExecuteReader();
            while (reader.Read())
            {
                textBox1.Text = reader["nombre1"].ToString();
                textBox2.Text = reader["nombre2"].ToString();
                textBox3.Text = reader["apellido1"].ToString();
                textBox4.Text = reader["apellido2"].ToString();
                textBox5.Text = reader["clave"].ToString();
                textBox6.Text = reader["orientacion"].ToString();

            }

            this.oleDbConnection1.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.oleDbDataAdapter1.InsertCommand.CommandText = "INSERT INTO alumno ( nombre1, nombre2, apellido1, apellido2, clave, orientacion) VALUES ('" + this.textBox1.Text + "','" + this.textBox2.Text + "' , '" + this.textBox3.Text + "','" + this.textBox4.Text + "','" + this.textBox5.Text + "','" + this.textBox6.Text + "')";

                this.oleDbConnection1.Open();
                this.oleDbDataAdapter1.InsertCommand.Connection = oleDbConnection1;

                this.oleDbDataAdapter1.InsertCommand.ExecuteNonQuery();

                this.oleDbConnection1.Close();

                MessageBox.Show("Registro agregado exitosamente");  //inform the user

                this.textBox1.Text = "";
                this.textBox2.Text = "";
                this.textBox3.Text = "";
                this.textBox4.Text = "";
                this.textBox5.Text = "";
                this.textBox6.Text = "";

            }
            catch (System.Data.OleDb.OleDbException exp)
            {
                this.oleDbConnection1.Close();

                MessageBox.Show(exp.ToString());
            }
            actual = getFirstId();
            showData();
            
        }

        private void creadordatos_Load(object sender, EventArgs e)
        {
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.oleDbDataAdapter1.UpdateCommand.CommandText =
                    "UPDATE alumno SET " + "nombre1 ='" + this.textBox1.Text + "', nombre2 ='" + this.textBox2.Text + "', apellido1 ='" + this.textBox3.Text + "', apellido2 ='" + this.textBox4.Text + "', clave ='" + this.textBox5.Text + "', orientacion ='" + this.textBox6.Text + "'" + " WHERE  Id =" + actual;

                this.oleDbConnection1.Open();

                this.oleDbDataAdapter1.UpdateCommand.Connection = oleDbConnection1;

                this.oleDbDataAdapter1.UpdateCommand.ExecuteNonQuery();

                this.oleDbConnection1.Close();

                MessageBox.Show("Registro actualizado correctamente.");

                this.textBox1.Text = "";
                this.textBox2.Text = "";
                this.textBox3.Text = "";
                this.textBox4.Text = "";
                this.textBox5.Text = "";
                this.textBox6.Text = "";
            }
            catch (System.Data.OleDb.OleDbException exp)
            {
                this.oleDbConnection1.Close();
                MessageBox.Show(exp.ToString());
            }
            actual = getFirstId();
            showData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            MsgBoxResult x = default(MsgBoxResult);
            string numero = null;
            numero = Interaction.InputBox("Digite Número");
            x = Interaction.MsgBox("En realidad desea eliminar el registro", MsgBoxStyle.YesNo);
            if (x== Constants.vbNo)
            {
                return;
            
            }
           
            else
            {
                try
                {
                    this.oleDbDataAdapter1.DeleteCommand.CommandText =
                        "DELETE FROM alumno WHERE nombre1 ='" + this.textBox1.Text + "'";

                    this.oleDbConnection1.Open();

                    this.oleDbDataAdapter1.DeleteCommand.Connection = oleDbConnection1;

                    this.oleDbDataAdapter1.DeleteCommand.ExecuteNonQuery();

                    this.oleDbConnection1.Close();

                    MessageBox.Show("Registro eliminado correctamente");

                    this.textBox1.Text = "";
                    this.textBox2.Text = "";
                    this.textBox3.Text = "";
                    this.textBox4.Text = "";
                    this.textBox5.Text = "";
                    this.textBox6.Text = "";

                    actual = getFirstId();
                    showData();
                }
                catch (System.Data.OleDb.OleDbException exp)
                {
                    this.oleDbConnection1.Close();
                    MessageBox.Show(exp.ToString());
                }
            }
            }
           

        private void button4_Click(object sender, EventArgs e)
        {
            String nombre = textBox1.Text;
            this.oleDbDataAdapter1.SelectCommand.CommandText = "SELECT * FROM alumno WHERE nombre1 = '" + nombre + "'";
            this.oleDbConnection1.Open();
            this.oleDbDataAdapter1.SelectCommand.Connection = oleDbConnection1;

            OleDbDataReader reader = this.oleDbDataAdapter1.SelectCommand.ExecuteReader();
            while (reader.Read())
            {
                textBox1.Text = reader["nombre1"].ToString();
                textBox2.Text = reader["nombre2"].ToString();
                textBox3.Text = reader["apellido1"].ToString();
                textBox4.Text = reader["apellido2"].ToString();
                textBox5.Text = reader["clave"].ToString();
                textBox6.Text = reader["orientacion"].ToString();
            }

            this.oleDbConnection1.Close();
        }
    }
}
