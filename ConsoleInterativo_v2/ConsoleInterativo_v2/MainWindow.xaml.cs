using System.Windows;

namespace ConsoleInterativo_v2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BotaoSim_Click(object sender, RoutedEventArgs e)
        {
            // Autorização concedida, executa os comandos no PowerShell (simulando com uma mensagem)
            MessageBox.Show("Executando comandos no PowerShell como administrador...");
        }

        private void BotaoNao_Click(object sender, RoutedEventArgs e)
        {
            // Autorização negada, fecha o programa
            Application.Current.Shutdown();
        }
    }
}
