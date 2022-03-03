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
    /// Lógica de interacción para BusquedaAvanzada.xaml
    /// </summary>
    public partial class BusquedaAvanzada : Window
    {
        public BusquedaAvanzada()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                String nomReceta = tbBusqueda.Text;
                ControlRecetas c = new ControlRecetas();
                dgBusqueda.ItemsSource = c.buscaAvanzada(nomReceta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontraron recetas" + ex);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            General w = new General();
            w.Show();
        }
    }
}
