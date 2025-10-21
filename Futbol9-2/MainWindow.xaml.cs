using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Futbol9_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void MostrarPanel(StackPanel panel)
        {
            Configuracion.Visibility = Visibility.Collapsed;
            InscripcionesPagos.Visibility = Visibility.Collapsed;
            Equipos.Visibility = Visibility.Collapsed;
            Jugadores.Visibility = Visibility.Collapsed;
            Grupos.Visibility = Visibility.Collapsed;
            Calendario.Visibility = Visibility.Collapsed;
            PartidosResultados.Visibility = Visibility.Collapsed;
            GolesEstadisticas.Visibility = Visibility.Collapsed;
            TablaPosiciones.Visibility = Visibility.Collapsed;

            panel.Visibility = Visibility.Visible;
        }

        private void AbrirConfiguracion(object sender, RoutedEventArgs e)
        {
            MostrarPanel(Configuracion);
        }

        private void AbrirInscripciones(object sender, RoutedEventArgs e)
        {
            MostrarPanel(InscripcionesPagos);
        }

        private void AbrirEquipos(object sender, RoutedEventArgs e)
        {
            MostrarPanel(Equipos);
        }

        private void AbrirJugadores(object sender, RoutedEventArgs e)
        {
            MostrarPanel(Jugadores);
        }

        private void AbrirGrupos(object sender, RoutedEventArgs e)
        {
            MostrarPanel(Grupos);
        }

        private void AbrirCalendario(object sender, RoutedEventArgs e)
        {
            MostrarPanel(Calendario);
        }

        private void AbrirPartidos(object sender, RoutedEventArgs e)
        {
            MostrarPanel(PartidosResultados);
        }

        private void AbrirGoles(object sender, RoutedEventArgs e)
        {
            MostrarPanel(GolesEstadisticas);
        }

        private void AbrirTabla(object sender, RoutedEventArgs e)
        {
            MostrarPanel(TablaPosiciones);
        }

        private void btnRegistrarInscripcion_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnVerificarDeuda_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnConfirmarPago_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}