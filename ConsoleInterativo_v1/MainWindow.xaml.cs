using System;
using System.Diagnostics;
using System.Security.Principal;
using System.Windows;

namespace ConsoleInterativo_v2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RealizarPadronizacao_Click(object sender, RoutedEventArgs e)
        {
            CustomMessageBox customMessageBox = new CustomMessageBox();
            customMessageBox.ShowDialog();

            if (customMessageBox.Autorizado)
            {
                // Autorização concedida, executa os comandos no PowerShell (simulando com uma mensagem)
                MessageBox.Show("Executando comandos no PowerShell como administrador...");
            }
            else
            {
                // Autorização negada, fecha o programa
                Application.Current.Shutdown();
            }
        }

    }
}
