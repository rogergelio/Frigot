using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Frigot
{
    /// <summary>
    /// Lógica de interacción para BajaProducto.xaml
    /// </summary>
    public partial class BajaProducto : Window
    {
        public BajaProducto()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            General w = new General();
            w.Show();
        }

        private void EliminarBt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
               
                Producto p = new Producto();
                int res = p.eliminaProducto(nombreProductoTxt.Text);
                if (res > 0)
                    MessageBox.Show("Producto eliminado");
                else
                    MessageBox.Show("Producto NO eliminado");

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al eliminar producto" + ex);
            }
        }
    }
}
