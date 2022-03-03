using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frigot
{
    class Alergia
    {
        public Int16 idAlergia { get; set; }
        public String nomAlergia { get; set; }
        public Int16 idUsuario ;
     
        public Alergia()
        {
            this.idUsuario = Int16.Parse(App.Current.Properties["idUsuario"].ToString());
        }

        public int agregaAlergia(String nombre)
        {

            int res = 0;
            SqlConnection con = Conexion.agregarConexion();
            SqlCommand cmd = new SqlCommand(string.Format(("insert into alergia (idAlergia, nombreAlergia, idUsuario) values ('{0}','{1}', '{2}')"), asignaIDalergia(), nombre, idUsuario), con);
            res = cmd.ExecuteNonQuery();
            con.Close();
            return res;

        }

        public int eliminaAlergia(String nombre)
        {
            int res = 0;
            SqlConnection con = Conexion.agregarConexion();
            SqlCommand cmd = new SqlCommand(string.Format(("delete from alergia where nombreAlergia = '{0}' and idUsuario = '{1}'"), nombre, idUsuario), con);
            res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }

        public List<Alergia> mostrarAlergias()
        {
            List<Alergia> lis = new List<Alergia>();
            Alergia a;
            SqlConnection con = Conexion.agregarConexion();
            SqlCommand cmd = new SqlCommand(String.Format(("select idAlergia, nombreAlergia from alergia where idUsuario = '{0}'"),idUsuario), con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                a = new Alergia();
                a.idAlergia = dr.GetInt16(0);
                a.nomAlergia = dr.GetString(1);
                lis.Add(a);
            }
            con.Close();
            return lis;
        }
        

        public int asignaIDalergia()
        {
            int res = 1;
            SqlConnection con;
            SqlCommand cmd;
            SqlDataReader dr;
            con = Conexion.agregarConexion();
            cmd = new SqlCommand("select idAlergia from alergia", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int id = dr.GetInt16(0);
                if (id >= res)
                    res = id + 1;
            }
            con.Close();
            return res;
        }
    }
}

