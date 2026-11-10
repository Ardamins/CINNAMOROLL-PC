using System.Windows;
using System.Windows.Controls;

namespace Cinnamoroll
{
    public partial class Configuracion : Window
    {
        public Configuracion()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            App.ProveedorIA = ((ComboBoxItem)ComboProveedor.SelectedItem).Content.ToString();
            App.UrlIA = TxtUrl.Text;
            App.ApiKey = TxtApiKey.Password;
            App.ModeloIA = TxtModelo.Text;

            MessageBox.Show("¡Ajustes guardados! Cinnamoroll ya es más inteligente ♡", "Éxito");
            this.Close();
        }

        // NUEVO: Evento para cerrar la ventana
        private void BtnCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}