using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Frigot
{
    class Producto
    {
        public Int16 idProd { get; set; }
        public String nomProd { get; set; }
        public Int32 cantGram { get; set; }
        public DateTime fechaCad { get; set; }
        public Int16 idUsuario { get; set; }
        public static Int16 idU = Int16.Parse(App.Current.Properties["idUsuario"].ToString());

        public Producto()
        {
            this.idUsuario = idU;

        }

        public Producto(string nomProd, short cantGram, DateTime fechaCad)
        {
            this.idProd = idProd;
            this.nomProd = nomProd;
            this.cantGram = cantGram;
            this.fechaCad = fechaCad;
        }

        public Producto(short idProd, string nomProd, short cantGram)
        {
            this.idProd = idProd;
            this.nomProd = nomProd;
            this.cantGram = cantGram;
            
        }

        public Producto(short idProd)
        {
            this.idProd = idProd;
        }

        public int agregarProducto(Producto a)
        {
            int res = 0;
            
            SqlConnection con = Conexion.agregarConexion();
            SqlCommand cmd = new SqlCommand(String.Format("insert into producto (idProd, nomProd, cantGram, fechaCad, idUsuario) values ('{0}','{1}', '{2}', '{3}', '{4}')", asignaIDProd(), a.nomProd, a.cantGram, a.fechaCad.ToString("yyyy'-'MM'-'dd"),idU), con);
            res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }

        public int eliminaProducto(String nomProd)
        {
            int res = 0;
            SqlConnection con = Conexion.agregarConexion();
            SqlCommand cmd = new SqlCommand(string.Format(("delete from producto where nomProd = '{0}' and idUsuario = '{1}'"), nomProd,idU), con);
            res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }

        public List<Producto> inventarioProductos()
        {
            List<Producto> lis = new List<Producto>();
            Producto p;
            SqlConnection con = Conexion.agregarConexion();
            SqlCommand cmd = new SqlCommand(String.Format("select idProd, nomProd, cantGram, fechaCad from producto", idU), con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                p = new Producto();
                p.idProd = dr.GetInt16(0);
                p.nomProd = dr.GetString(1);
                p.cantGram = dr.GetInt32(2);
                p.fechaCad = dr.GetDateTime(3);

                lis.Add(p);
            }
            con.Close();
            return lis;
        }

        public int asignaIDProd()
        {
            int res = 1;
            SqlConnection con;
            SqlCommand cmd;
            SqlDataReader dr;
            con = Conexion.agregarConexion();
            cmd = new SqlCommand("select idProd from producto", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int id = dr.GetInt16(0);
                if (id >= res)
                    res = id+1;
            }

                
            con.Close();
            return res;
        }


    }

}
