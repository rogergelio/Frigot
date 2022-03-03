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
    /// Lógica de interacción para InfoUsuario.xaml
    /// </summary>
    public partial class InfoUsuario : Window
    {
        public InfoUsuario()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cbUsuario.Items.Add("Agregar alergia");
            cbUsuario.Items.Add("Eliminar alergia");
            cbUsuario.Items.Add("Mostrar alergias");
            cbUsuario.SelectedIndex = 2;

        }

        private void btReg_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            General w = new General();
            w.Show();
        }

        private void btEje_Click(object sender, RoutedEventArgs e)
        {
            if(cbUsuario.SelectedIndex == 0)
            {
                try
                {
                    int res;
                    Alergia u = new Alergia();
                    res = u.agregaAlergia(tbAlergia.Text);
                    if (res > 0)
                        MessageBox.Show("Alergia agregada");
                    else
                        MessageBox.Show("Alergia NO agregada");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar alergia" + ex);
                }
            }

            else if(cbUsuario.SelectedIndex == 1)
            {
                try
                {
                    int res;
                    Alergia u = new Alergia(); ;
                    res = u.eliminaAlergia(tbAlergia.Text);
                    if (res > 0)
                        MessageBox.Show("Alergia eliminada");
                    else
                        MessageBox.Show("Alergia NO eliminada");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar alergia" + ex);
                }
            }
            else
            {
                try
                {
                    Alergia a = new Alergia();
                    dgAlergia.ItemsSource = a.mostrarAlergias();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se encontraron productos" + ex);
                }
            }
        }
    }
}
