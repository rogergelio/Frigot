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
    /// Lógica de interacción para Inventario.xaml
    /// </summary>
    public partial class Inventario : Window
    {
        public Inventario()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            General w = new General();
            w.Show();
        }

     

        private void btMostrar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Producto p = new Producto();
                dgDatos.ItemsSource = p.inventarioProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontraron productos" + ex);
            }

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

       
    }
}
