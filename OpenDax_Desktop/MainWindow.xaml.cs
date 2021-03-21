using OpenDax_Core.Exchanges;
using System.Threading.Tasks;
using System.Windows;

namespace OpenDax_Desktop
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var exchange = new YellowPublic();

            Task.Run(async () =>
            {
                await exchange.InitAsync();
            });
        }
    }
}
