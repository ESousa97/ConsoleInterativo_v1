using System.Windows;

namespace SeuNamespace
{
    public partial class CustomMessageBox : Window
    {
        public bool Autorizado { get; private set; }

        public CustomMessageBox()
        {
            InitializeComponent();
        }

        private void Sim_Click(object sender, RoutedEventArgs e)
        {
            Autorizado = true;
            Close();
        }

        private void Nao_Click(object sender, RoutedEventArgs e)
        {
            Autorizado = false;
            Close();
        }
    }
}
