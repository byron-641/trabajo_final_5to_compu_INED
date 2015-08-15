using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajo_final_reloaded
{
    class temporal
    {
         if (radioButton1.Checked == true)
            {
                try
                {
                    
                    this.oleDbDataAdapter1.InsertCommand.CommandText = "INSERT INTO alumno ( materia1b1, materia2b1, materia3b1, materia4b1, materia5b1, materia6b6, materia7b1, materia8b1, materia9b1, materia10b1, materia11b1, materia12b1, materia13b1, promediob1) VALUES ('" + this.textBox6.Text + "','" + this.textBox7.Text + "' , '" + this.textBox8.Text + "','" + this.textBox9.Text + "','" + this.textBox10.Text + "','" + this.textBox11.Text + "','" + this.textBox12.Text + "','" + this.textBox13.Text + "','" + this.textBox14.Text + "','" + this.textBox15.Text + "','" + this.textBox16.Text + "','" + this.textBox17.Text + "','" + this.textBox18.Text + "','" + this.textBox19.Text + "',)";

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
            if (radioButton2.Checked == true)
            {
                try
                {

                    this.oleDbDataAdapter1.InsertCommand.CommandText = "INSERT INTO alumno ( materia1b2, materia2b2, materia3b2, materia4b2, materia5b2, materia6b2, materia7b2, materia8b2, materia9b2, materia10b2, materia11b2, materia12b2, materia13b2, promediob2) VALUES ('" + this.textBox6.Text + "','" + this.textBox7.Text + "' , '" + this.textBox8.Text + "','" + this.textBox9.Text + "','" + this.textBox10.Text + "','" + this.textBox11.Text + "','" + this.textBox12.Text + "','" + this.textBox13.Text + "','" + this.textBox14.Text + "','" + this.textBox15.Text + "','" + this.textBox16.Text + "','" + this.textBox17.Text + "','" + this.textBox18.Text + "','" + this.textBox19.Text + "',)";

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
            if (radioButton3.Checked == true)
            {
                try
                {

                    this.oleDbDataAdapter1.InsertCommand.CommandText = "INSERT INTO alumno ( materia1b3, materia2b3, materia3b3, materia4b3, materia5b3, materia6b3, materia7b3, materia8b3, materia9b3, materia10b3, materia11b3, materia12b3, materia13b3, promediob3) VALUES ('" + this.textBox6.Text + "','" + this.textBox7.Text + "' , '" + this.textBox8.Text + "','" + this.textBox9.Text + "','" + this.textBox10.Text + "','" + this.textBox11.Text + "','" + this.textBox12.Text + "','" + this.textBox13.Text + "','" + this.textBox14.Text + "','" + this.textBox15.Text + "','" + this.textBox16.Text + "','" + this.textBox17.Text + "','" + this.textBox18.Text + "','" + this.textBox19.Text + "',)";

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
            if (radioButton4.Checked == true)
            {
                try
                {

                    this.oleDbDataAdapter1.InsertCommand.CommandText = "INSERT INTO alumno ( materia1b4, materia2b4, materia3b4, materia4b4, materia5b4, materia6b4, materia7b4, materia8b4, materia9b4, materia10b4, materia11b4, materia12b4, materia13b4, promediob4) VALUES ('" + this.textBox6.Text + "','" + this.textBox7.Text + "' , '" + this.textBox8.Text + "','" + this.textBox9.Text + "','" + this.textBox10.Text + "','" + this.textBox11.Text + "','" + this.textBox12.Text + "','" + this.textBox13.Text + "','" + this.textBox14.Text + "','" + this.textBox15.Text + "','" + this.textBox16.Text + "','" + this.textBox17.Text + "','" + this.textBox18.Text + "','" + this.textBox19.Text + "',)";

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
            else
            {
                MessageBox.Show("Seleccione Bimestre");

            }
        
    }
}
