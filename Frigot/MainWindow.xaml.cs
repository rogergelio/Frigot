using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Frigot
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con;
            
            SqlCommand cmd;
            
            SqlDataReader dr;
            
            try
            {
                con = Conexion.agregarConexion();
                
                cmd = new SqlCommand(String.Format("SELECT contra, idUsuario FROM usuarios where nombreUsuario='{0}'", UsuarioLogIn.Text), con);
                
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if (dr.GetString(0).Equals(ContrasenaLogIn.Text))
                    {
                        this.Hide();
                        General w = new General();
                        w.Show();
                        App.Current.Properties["idUsuario"] = dr.GetInt16(1).ToString();
                        
                            
                    }
                    else
                        MessageBox.Show("Contraseña incorrecta");

                }
                else
                    MessageBox.Show("Usuario incorrecto");
                con.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error: " + ex.ToString());
                this.Hide();
                General w = new General();
                w.Show();
                App.Current.Properties["idUsuario"] = dr.GetInt16(1).ToString();
            }


        }
    

        private void UsuarioLogIn_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
