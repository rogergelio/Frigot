using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frigot
{
    class ControlRecetas
    {
        public Int16 idReceta { get; set; }
        public String nombre { get; set; }

        public String region { get; set; }
        public String instrucciones { get; set; }

        public ControlRecetas(short idReceta, string nombre, string region, string instrucciones)
        {
            this.idReceta = idReceta;
            this.nombre = nombre;
            this.region = region;
            this.instrucciones = instrucciones;
        }

        public ControlRecetas()
        {

        }
     

        public List<ControlRecetas> buscarReceta(String nombre)
        {
            List<ControlRecetas> res = new List<ControlRecetas>();
            SqlConnection con = Conexion.agregarConexion();
            SqlCommand cmd = new SqlCommand(String.Format("select idReceta,nombre,region,instrucciones from recetas where nombre like '%{0}%'", nombre), con);
            SqlDataReader dr = cmd.ExecuteReader();
            ControlRecetas c;
            c = new ControlRecetas();
            if (dr.Read())
            {
                c.idReceta = dr.GetInt16(0);
                c.nombre = dr.GetString(1);
                c.region = dr.GetString(2);
                c.instrucciones = dr.GetString(3);
            }
            
            res.Add(c);
            return res;
        }

        public List<ControlRecetas> buscaAvanzada(String nombreP)
        {
            List<ControlRecetas> res = new List<ControlRecetas>();
            SqlConnection con = Conexion.agregarConexion();
            SqlCommand cmd = new SqlCommand(String.Format("select recetas.idReceta,nombre,region,instrucciones from recetas inner join productoReceta on recetas.idReceta = productoReceta.idReceta inner join producto on productoReceta.idProd = producto.idProd where nomProd like '%{0}%'", nombreP), con);
            SqlDataReader dr = cmd.ExecuteReader();
            ControlRecetas c;
            c = new ControlRecetas();
            if (dr.Read())
            {
                c.idReceta = dr.GetInt16(0);
                c.nombre = dr.GetString(1);
                c.region = dr.GetString(2);
                c.instrucciones = dr.GetString(3);
            }

            res.Add(c);
            return res;
        }

    }
}
