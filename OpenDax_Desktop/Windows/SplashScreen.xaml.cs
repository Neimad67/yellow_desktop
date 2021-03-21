using OpenDax_Desktop.Contexts;
using System;
using System.Threading.Tasks;
using System.Windows;

namespace OpenDax_Desktop.Windows
{
    /// <summary>
    /// Logique d'interaction pour SplashScreen.xaml
    /// </summary>
    public partial class SplashScreen : Window
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var dataContext = DataContext as ViewModels.SplashScreenVM;
            ExchangeContext.PublicInstace.OnConnected += PublicInstace_OnConnected;

            Task.Run(async () =>
            {
                await dataContext.InitAsync();
            });
        }

        private void PublicInstace_OnConnected()
        {
            // need to use delegate in order to get access to the main thread UI (else we got exception)

            Application.Current.Dispatcher.BeginInvoke((Action)delegate
            {
                var mainWindow = new MainWindow();
                mainWindow.Show();

                Close();
            });           
        }
    }
}
