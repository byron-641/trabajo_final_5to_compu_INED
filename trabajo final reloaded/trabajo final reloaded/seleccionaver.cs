﻿using System;
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
    public partial class seleccionaver : Form
    {
        public seleccionaver()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            visualizador visualizador = new visualizador();
            visualizador.Show();
        }
    }
}
