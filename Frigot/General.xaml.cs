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
    /// Lógica de interacción para General.xaml
    /// </summary>
    public partial class General : Window
    {
        public General()
        {
            InitializeComponent();
        }

        private void salirBt_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            RegistroP rp = new RegistroP();
            rp.Show(); 
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Hide();
            BusquedaAvanzada ba = new BusquedaAvanzada();
            ba.Show(); 
        }

        private void bajaBt_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            BajaProducto bp = new BajaProducto();
            bp.Show(); 
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            InfoUsuario iu = new InfoUsuario();
            iu.Show(); 
        }

        private void inventarioBt_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Inventario i = new Inventario();
            i.Show(); 
        }

        private void recetasBt_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Recetas r = new Recetas();
            r.Show(); 
        }
    }
}
