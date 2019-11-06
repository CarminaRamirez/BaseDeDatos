using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TpBaseDeDatos
{
    public class Conexión
    {
        SqlConnection cn;
        SqlCommand cmd;
        //SqlDataReader dr;
        SqlDataAdapter da;
        DataTable tabla;

        public Conexión()
        {
            try
            {
                cn = new SqlConnection("Data Source=LAPTOP-RIC0EAK5\\SQLEXPRESS;Initial Catalog=TP2BD;Integrated Security=True");
                cn.Open();
                MessageBox.Show("Conectado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se conecto con la base de datos: " + ex.ToString());
            }
        }

        public void LeerTabla(DataGridView dgv, Byte nro)
        {
            try
            {
                da = new SqlDataAdapter($"Select * from PROPIEDADES where [Nro-Zona]={nro}", cn);
                tabla = new DataTable();
                da.Fill(tabla);
                dgv.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo llenar el DataGridView: {ex.Message}");
            }
        }



        public string insertar(Int16 numprop, Byte numzona, DateTime fecha, string tipoconst, Byte cantdorm, Byte cantba, Byte cantco, Int32 metroscons, Int32 metrosterr, string ori, string modofe, decimal valor, DateTime fechaactu, string tipodoc, string numdoc, string numero)
        {
            string resultado = "Se insertó";
            try
            {
              //  cmd = new SqlCommand("insert into PROPIEDADES/PAGOS([Nro-Propiedad],[Cod-Cond-Pago]) values("+numprop+",'"+numero+"')");
              //  cmd.ExecuteNonQuery();
                cmd = new SqlCommand("execute AltaPropiedad " + numprop + "," + numzona + ",'" + fecha.Date + "','" + tipoconst + "'," + cantdorm + "," + cantba + "," + cantco + "," + metroscons + "," + metrosterr + ",'" + ori + "','" + modofe + "'," + valor + ",'" + fechaactu.Date + "','" + tipodoc + "','" + numdoc + "','" + numero + "'",cn);
              //  cmd = new SqlCommand("insert into PROPIEDADES([Nro-Propiedad],[Nro-Zona],[Fecha-Ingreso-Cartera],[Tipo-Construcción],[Cant-Dormitorios],[Cant-Baños],[Cant-Cocheras],[M2-Construidos],[M2-Terreno],[Orientación],[Modalidad-Oferta],[Valor],[Fecha-Act-Precio],[Tipo-Doc-Propietario],[Nro-Doc-Propietario]) " +
              //      "values("+numprop+","+numzona+",'"+fecha.Date+"','"+tipoconst+"',"+cantdorm+ "," + cantba + "," + cantco + "," + metroscons + "," + metrosterr + ",'"+ori+"','"+modofe+"',"+valor+",'"+fechaactu.Date+"','"+tipodoc+"','"+numdoc+"')",cn); //faltaria pasar por parametro los bool
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                resultado = $"No se ha insertado: {ex.Message}";
            }
            return resultado;
        }


    }
}
