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
    public partial class editor : Form
    {
        public editor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox3.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            
               {
                 

                }
            if (radioButton2.Checked == true)
           {


           }
            if (radioButton3.Checked == true)
           {


           }
            if (radioButton4.Checked == true)
           {


           }
            else
              
               {
                   MessageBox.Show("Seleccione Bimestre");

               }
        }

        
    }
}
