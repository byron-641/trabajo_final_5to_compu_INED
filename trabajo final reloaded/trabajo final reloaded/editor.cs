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
    public partial class editor : Form
    {
        private int actual;
        
        public editor()

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


            }

            this.oleDbConnection1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
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
               
            }

            this.oleDbConnection1.Close();
            groupBox2.Visible = true;
            groupBox3.Visible = true;
            groupBox4.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12, n13, promedio;
            string promedio2;
            n1 = Convert.ToInt32(textBox6.Text);
            n2 = Convert.ToInt32(textBox7.Text);
            n3 = Convert.ToInt32(textBox8.Text);
            n4 = Convert.ToInt32(textBox9.Text);
            n5 = Convert.ToInt32(textBox10.Text);
            n6 = Convert.ToInt32(textBox11.Text);
            n7 = Convert.ToInt32(textBox12.Text);
            n8 = Convert.ToInt32(textBox13.Text);
            n9 = Convert.ToInt32(textBox14.Text);
            n10 = Convert.ToInt32(textBox15.Text);
            n11 = Convert.ToInt32(textBox16.Text);
            n12 = Convert.ToInt32(textBox17.Text);
            n13 = Convert.ToInt32(textBox18.Text);
            promedio = ((n1 + n2 + n3 + n4 + n5 + n6 + n7 + n8 + n9 + n10 + n11 + n12 + n13) / 13);
            promedio2 = Convert.ToString(promedio);
            textBox19.Text = promedio2;

            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {

                this.oleDbDataAdapter1.InsertCommand.CommandText = "INSERT INTO alumno ( materia1b1, materia2b1, materia3b1, materia4b1, materia5b1, materia6b1, materia7b1, materia8b1, materia9b1, materia10b1, materia11b1, materia12b1, materia13b1, promediob1) VALUES ('" + this.textBox6.Text + "','" + this.textBox7.Text + "' , '" + this.textBox8.Text + "','" + this.textBox9.Text + "','" + this.textBox10.Text + "','" + this.textBox11.Text + "','" + this.textBox12.Text + "','" + this.textBox13.Text + "','" + this.textBox14.Text + "','" + this.textBox15.Text + "','" + this.textBox16.Text + "','" + this.textBox17.Text + "','" + this.textBox18.Text + "','" + this.textBox19.Text + "',)";

                this.oleDbConnection1.Open();
                this.oleDbDataAdapter1.InsertCommand.Connection = oleDbConnection1;

                this.oleDbDataAdapter1.InsertCommand.ExecuteNonQuery();

                this.oleDbConnection1.Close();

                MessageBox.Show("Registro agregado exitosamente");  //inform the user

                this.textBox6.Text = "";
                this.textBox7.Text = "";
                this.textBox8.Text = "";
                this.textBox9.Text = "";
                this.textBox10.Text = "";
                this.textBox11.Text = "";
                this.textBox12.Text = "";
                this.textBox13.Text = "";
                this.textBox14.Text = "";
                this.textBox15.Text = "";
                this.textBox16.Text = "";
                this.textBox17.Text = "";
                this.textBox18.Text = "";
                this.textBox19.Text = "";

            }
            catch (System.Data.OleDb.OleDbException exp)
            {
                this.oleDbConnection1.Close();

                MessageBox.Show(exp.ToString());
            }
            actual = getFirstId();
            showData();
        }

        
    }
}
