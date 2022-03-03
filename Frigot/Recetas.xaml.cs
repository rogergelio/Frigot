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
    /// Lógica de interacción para Recetas.xaml
    /// </summary>
    public partial class Recetas : Window
    {
        public Recetas()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try 
            { 
                String nomReceta = cbRecetas.SelectedItem.ToString();
                ControlRecetas c = new ControlRecetas();
                dgRecetas.ItemsSource = c.buscarReceta(nomReceta);
             
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar recetas" + ex);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            General w = new General();
            w.Show();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                Conexion c = new Conexion();
                c.llenarCombo(cbRecetas);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar recetas" + ex);
            }
        }
    }
}
