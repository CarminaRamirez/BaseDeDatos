﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TpBaseDeDatos
{
    public partial class Inicial : Form
    {
        public Inicial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Consulta consulta = new Consulta();
            consulta.Owner = this;
            consulta.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Alta alta = new Alta();
            alta.Owner = this;
            alta.Show();
        }

        private void Inicial_Load(object sender, EventArgs e)
        {
           // Conexión c = new Conexión();
        }
    }
}
