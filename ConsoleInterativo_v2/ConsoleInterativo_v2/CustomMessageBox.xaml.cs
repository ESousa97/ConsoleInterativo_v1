using System.Windows;
using System.Windows.Media;

namespace ConsoleInterativo_v2
{
    public partial class CustomMessageBox : Window
    {
        // Propriedades de Estilização
        public string Mensagem { get; set; }
        public string BotaoSimTexto { get; set; }
        public string BotaoNaoTexto { get; set; }
        public Brush BackgroundCor { get; set; }
        public Brush TextoCor { get; set; }
        public Brush BotaoSimCor { get; set; }
        public Brush BotaoNaoCor { get; set; }

        public RespostaUsuario Resposta { get; private set; }

        public CustomMessageBox()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void BotaoSim_Click(object sender, RoutedEventArgs e)
        {
            Resposta = RespostaUsuario.Sim;
            Close();
        }

        private void BotaoNao_Click(object sender, RoutedEventArgs e)
        {
            Resposta = RespostaUsuario.Nao;
            Close();
        }
    }
}
