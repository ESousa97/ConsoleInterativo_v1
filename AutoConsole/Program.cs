using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Iniciando PowerShell como administrador...");

        // Configura as opções para iniciar o PowerShell como administrador
        ProcessStartInfo psi = new ProcessStartInfo
        {
            FileName = "powershell.exe",
            Verb = "runas",  // Solicita privilégios elevados
            UseShellExecute = true
        };

        // Inicia o processo
        try
        {
            Process.Start(psi);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao iniciar o PowerShell: " + ex.Message);
        }
    }
}
