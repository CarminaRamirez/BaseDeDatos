using System;
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
    public partial class Alta : Form
    {
        public Conexión c { get; set; }
        
        public Alta()
        {
            InitializeComponent();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Alta_Load(object sender, EventArgs e)
        {
            c = new Conexión();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string modalidad;
            if (radioButton1.Checked)
                modalidad = radioButton1.Text;
            else
                modalidad = radioButton2.Text;
            string numero = "";
            if (comboBox2.Text == "Transferencia")
                numero = "4";
            if (comboBox2.Text == "Débito")
                numero = "3";
            if (comboBox2.Text == "Crédito")
                numero = "2";
            if (comboBox2.Text == "Efectivo")
                numero = "1";

            MessageBox.Show(c.insertar(Convert.ToInt16(textBox2.Text), Convert.ToByte(textBox3.Text), DateTime.Now, textBox5.Text, Convert.ToByte(textBox6.Text),
                    Convert.ToByte(textBox7.Text), Convert.ToByte(textBox8.Text), Convert.ToInt32(textBox9.Text), Convert.ToInt32(textBox10.Text),
                    comboBox1.Text, modalidad, Convert.ToDecimal(textBox13.Text), Convert.ToDateTime(textBox14.Text), textBox15.Text, textBox16.Text, numero));
        }
    }
}
