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
    public partial class creadornotas : Form
    {
        private int actual;
        public creadornotas()
        {
            actual = getFirstId();
            InitializeComponent();
        }
        
         public System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
         public System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
        public System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
        public System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
        public System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
        public System.Data.OleDb.OleDbConnection oleDbConnection1;
        
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

        private int getFirstId()
        {
            OleDbDataAdapter oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
           
        

            OleDbDataReader reader = this.oleDbDataAdapter1.SelectCommand.ExecuteReader();
            reader.Read();
            int id = Convert.ToInt16(reader["Id"].ToString());

            this.oleDbConnection1.Close();

            return id;
}

        

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbConnection miconexion = new OleDbConnection(conexion.con);
            OleDbCommand guardar = new OleDbCommand("update into alumno(Id, materia1b1, materia2b1, materia3b1, materia4b1, materia5b1, materia6b1, materia7b1, materia8b1, materia9b1, materia10b1, materia11b1, materia12b1, materia13b1, promediob1)values(@materia1b1, @materia2b1, @materia3b1, @materia4b1, @materia5b1, @materia6b1, @materia7b1, @materia8b1, @materia9b1, @materia10b1, @materia11b1, @materia12b1, @materia13b1, @promediob1)", miconexion);
            OleDbCommand actualizar = new OleDbCommand("update alumno set Id=@Id" ,miconexion);
            
            guardar.Parameters.AddWithValue("materia1b1",textBox6.Text);
            guardar.Parameters.AddWithValue("materia2b1", textBox7.Text);
            guardar.Parameters.AddWithValue("materia3b1", textBox8.Text);
            guardar.Parameters.AddWithValue("materia4b1", textBox9.Text);
            guardar.Parameters.AddWithValue("materia5b1", textBox10.Text);
            guardar.Parameters.AddWithValue("materia6b1", textBox11.Text);
            guardar.Parameters.AddWithValue("materia7b1", textBox12.Text);
            guardar.Parameters.AddWithValue("materia8b1", textBox13.Text);
            guardar.Parameters.AddWithValue("materia9b1", textBox14.Text);
            guardar.Parameters.AddWithValue("materia10b1", textBox15.Text);
            guardar.Parameters.AddWithValue("materia11b1", textBox16.Text);
            guardar.Parameters.AddWithValue("materia12b1", textBox17.Text);
            guardar.Parameters.AddWithValue("materia13b1", textBox18.Text);
            guardar.Parameters.AddWithValue("promediob1", textBox19.Text);

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

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox3.Visible = true;
            groupBox4.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
        }
        }
}
    

