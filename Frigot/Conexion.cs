using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Frigot
{
    class Conexion
    {
        public static SqlConnection agregarConexion()
        {
            SqlConnection con;
            try
            {
                con = new SqlConnection("Data Source=DESKTOP-D9E5OSP;Initial Catalog=frigot;Integrated Security=True");
                con.Open();
                MessageBox.Show("Se conectó");
            }
            catch (Exception ex)
            {
                con = null;
                MessageBox.Show("No se pudo conectar"+ex);
            }
            return con;
        }
        public void llenarCombo(ComboBox cb)
        {
            try
            {
                SqlConnection con;
                SqlCommand cmd;
                SqlDataReader dr;
                con = Conexion.agregarConexion();
                cmd = new SqlCommand("select nombre from recetas", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                    cb.Items.Add(dr["nombre"].ToString());
                cb.SelectedIndex = 0;
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("el combo no se lleno por el error" + ex);
            }
        }


    }
}
