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
    /// Lógica de interacción para RegistroP.xaml
    /// </summary>
    public partial class RegistroP : Window
    {
        public RegistroP()
        {
            InitializeComponent();
        }

        private void Bt_ClickAlta(object sender, RoutedEventArgs e)
        {
            try
            {
                int res;
                Producto p = new Producto( tbNomProd.Text, Int16.Parse(tbCantGram.Text), DateTime.Parse(fechaCad.Text));
                res = p.agregarProducto(p);
                if (res > 0)
                    MessageBox.Show("Producto dado de alta");
                else
                    MessageBox.Show("Producto NO dado de alta");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo registrar producto" + ex);
            }
        }

        private void Bt_ClickRegresar(object sender, RoutedEventArgs e)
        {
            this.Hide();
            General w = new General();
            w.Show();
        }
    }
}
