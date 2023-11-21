using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bem-vindo ao Console Interativo!");

        while (true)
        {
            Console.Write("> ");
            string comando = Console.ReadLine();

            if (comando.ToLower() == "sair")
            {
                break;
            }

            ProcessarComando(comando);
        }

        Console.WriteLine("Obrigado por usar o Console Interativo!");
    }

    static void ProcessarComando(string comando)
    {
        // Adicione lógica para processar comandos aqui
        Console.WriteLine($"Comando recebido: {comando}");
    }
}
