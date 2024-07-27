using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Threading;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KeyAuth
{
    class Program
    {
        public static api KeyAuthApp = new api(
            name: "SpooferVK",
            ownerid: "iLQDYH3HO1",
            secret: "24d406983e7e2bd347ae48bcbe552728fb8927439750dc20c48faa3cbee242e8",
            version: "1.0"
        );

        private void ShowResponse(string type)
        {
            Console.WriteLine($"It took {api.responseTime} ms to {type}");
        }

        static void Main(string[] args)
        {
            Console.Title = "Loader";
            Console.WriteLine("Connecting..");
            KeyAuthApp.init();

            autoUpdate();

            if (!KeyAuthApp.response.success)
            {
                Console.WriteLine("\n Status: " + KeyAuthApp.response.message);
                Thread.Sleep(1500);
                Environment.Exit(0);
            }

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(@"██╗   ██╗██╗  ██╗███████╗██████╗  ██████╗  ██████╗ ███████╗███████╗██████╗ ");
            Console.WriteLine(@"██║   ██║██║ ██╔╝██╔════╝██╔══██╗██╔═══██╗██╔═══██╗██╔════╝██╔════╝██╔══██╗");
            Console.WriteLine(@"██║   ██║█████╔╝ ███████╗██████╔╝██║   ██║██║   ██║█████╗  █████╗  ██████╔╝");
            Console.WriteLine(@"╚██╗ ██╔╝██╔═██╗ ╚════██║██╔═══╝ ██║   ██║██║   ██║██╔══╝  ██╔══╝  ██╔══██╗");
            Console.WriteLine(@" ╚████╔╝ ██║  ██╗███████║██║     ╚██████╔╝╚██████╔╝██║     ███████╗██║  ██║");
            Console.WriteLine(@"  ╚═══╝  ╚═╝  ╚═╝╚══════╝╚═╝      ╚═════╝  ╚═════╝ ╚═╝     ╚══════╝╚═╝  ╚═╝");
            Console.WriteLine(@"");
            Console.WriteLine(@"");

            Console.Write("\n\n[+] Enter License: ");
            string key = Console.ReadLine();
            KeyAuthApp.license(key);

            if (!KeyAuthApp.response.success)
            {
                Console.WriteLine("\nStatus: " + KeyAuthApp.response.message);
                Thread.Sleep(2500);
                Environment.Exit(0);
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n[+] Logged In!");
            Thread.Sleep(2000);
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(@"██╗   ██╗██╗  ██╗███████╗██████╗  ██████╗  ██████╗ ███████╗███████╗██████╗ ");
            Console.WriteLine(@"██║   ██║██║ ██╔╝██╔════╝██╔══██╗██╔═══██╗██╔═══██╗██╔════╝██╔════╝██╔══██╗");
            Console.WriteLine(@"██║   ██║█████╔╝ ███████╗██████╔╝██║   ██║██║   ██║█████╗  █████╗  ██████╔╝");
            Console.WriteLine(@"╚██╗ ██╔╝██╔═██╗ ╚════██║██╔═══╝ ██║   ██║██║   ██║██╔══╝  ██╔══╝  ██╔══██╗");
            Console.WriteLine(@" ╚████╔╝ ██║  ██╗███████║██║     ╚██████╔╝╚██████╔╝██║     ███████╗██║  ██║");
            Console.WriteLine(@"  ╚═══╝  ╚═╝  ╚═╝╚══════╝╚═╝      ╚═════╝  ╚═════╝ ╚═╝     ╚══════╝╚═╝  ╚═╝");
            Console.WriteLine(@"");
            Console.WriteLine(@"");

            Console.WriteLine("\n[1] Spoofar \n[2] Exit");
            Console.Write("\nChoose Option: ");
            int option2 = int.Parse(Console.ReadLine());

            switch (option2)
            {
                case 1:
                    ExecuteSpoofingProcess();
                    break;
                case 2:
                    Environment.Exit(0);
                    break;
            }
        }

        static void ExecuteSpoofingProcess()
        {
            string batFilePath = "spoof.bat";

            // Criação do arquivo .bat
            using (StreamWriter writer = new StreamWriter(batFilePath))
            {
                writer.WriteLine("@echo off");
                writer.WriteLine("cls");
                writer.WriteLine("taskkill /f /im Steam.exe /t");
                writer.WriteLine("cls");
                writer.WriteLine(@"set hostspath=%windir%\System32\drivers\etc\hosts");
                writer.WriteLine("cls");
                writer.WriteLine(@"REG DELETE HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\MSLicensing\HardwareID / f");
                writer.WriteLine("cls");
                writer.WriteLine(@"REG DELETE HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\MSLicensing\Store / f");
                writer.WriteLine("cls");
                writer.WriteLine(@"REG DELETE HKEY_CURRENT_USER\Software\WinRAR\ArcHistory / f");
                writer.WriteLine("cls");
                writer.WriteLine(@"REG DELETE HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Services\bam\State\UserSettings\S-1-5-21-1282084573-1681065996-3115981261-1001 / va / f");
                writer.WriteLine("cls");
                writer.WriteLine(@"REG DELETE HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\FeatureUsage\ShowJumpView / f");
                writer.WriteLine("cls");
                writer.WriteLine(@"REG DELETE HKEY_CURRENT_USER\Software\Classes\Local Settings\Software\Microsoft\Windows\Shell\MuiCache / f");
                writer.WriteLine("cls");
                writer.WriteLine(@"REG DELETE HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\FeatureUsage\AppSwitched / f");
                writer.WriteLine("cls");
                writer.WriteLine(@"REG DELETE HKEY_CLASSES_ROOT\Local Settings\Software\Microsoft\Windows\Shell\MuiCache / f");
                writer.WriteLine("cls");
                writer.WriteLine(@"REG DELETE HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Services\bam\State\UserSettings\S-1-5-21-332004695-2829936588-140372829-1002 / f");
                writer.WriteLine("cls");
                writer.WriteLine(@"REG DELETE HKEY_CURRENT_USER\Software\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\Compatibility Assistant\Store / f");
                writer.WriteLine("cls");
                writer.WriteLine(@"REG DELETE HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Services\bam\State\UserSettings\S-1-5-21-1282084573-1681065996-3115981261-1001 / f");
                writer.WriteLine("cls");
                writer.WriteLine(@"REG DELETE HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\FeatureUsage\AppSwitched / f");
                writer.WriteLine("cls");
            }

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Spoofing...");

            // Executa o arquivo .bat
            Process process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = $"/C start \"\" \"{batFilePath}\"",
                    WindowStyle = ProcessWindowStyle.Hidden,
                    CreateNoWindow = true
                }
            };

            process.Start();
            process.WaitForExit(); // Aguarda o término do processo .bat

            // Aguarda 3 segundos antes de exibir a mensagem de conclusão e fechar
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Spoofed!");
            Thread.Sleep(3000); // 3 segundos
        }

        static void autoUpdate()
        {
            try
            {
                if (KeyAuthApp.checkforupdate())
                {
                    if (KeyAuthApp.response.update)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("[INFO] Atualizando o Loader...");
                        KeyAuthApp.downloadupdate();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("[INFO] Loader atualizado com sucesso!");
                        Thread.Sleep(2000);
                        Environment.Exit(0);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[ERRO] " + ex.Message);
                Thread.Sleep(2000);
                Environment.Exit(0);
            }
        }

        static string random_string()
        {
            string str = null;
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                str += Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65))).ToString();
            }
            return str;
        }
    }
}