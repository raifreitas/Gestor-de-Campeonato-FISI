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
using Futbol9_2.Data;
using Futbol9_2.Modelos;
using System.Linq;

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
            CargarDatos();
        }
        private void CargarDatos()
        {
            // Esta función ahora solo LEE de la base de datos.
            using (var context = new FutbolContext())
            {
                // 1. Lee la lista COMPLETA de equipos desde la BD SQL.
                var listaDeEquipos = context.Equipos.ToList();

                // 2. Muestra los datos en el DataGrid.
                dtgEquipos.ItemsSource = listaDeEquipos;
            }
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