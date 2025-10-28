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
            using (var context = new FutbolContext())
            {
                if (!context.Equipos.Any())
                {
                    var equipo1 = new Equipo {
                        NombreEquipo = "Los Ases de FISI",
                        Delegado = "Rai Jair",
                        Estado = "Activo",
                        Monto = 150.00,
                        FechaPago = DateTime.Now
                    };
                    var equipo2 = new Equipo {
                        NombreEquipo = "Real Sistemas",
                        Delegado = "Juan Pérez",
                        Estado = "Debe",
                        Monto = 100.00,
                        FechaPago = DateTime.Now.AddDays(-1)
                    };

                    context.Equipos.Add(equipo1);
                    context.Equipos.Add(equipo2);

                    context.SaveChanges();
                }
                var listaDeEquipos = context.Equipos.ToList();

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