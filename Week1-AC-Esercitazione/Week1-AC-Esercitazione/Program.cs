using System;
using System.IO;

namespace Week1_AC_Esercitazione
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Attendiamo spese.txt!\n");
            FileSystemWatcher fWather = new FileSystemWatcher();
            fWather.Path = @"C:\Users\eleonora.lombardo\Desktop\AC-Esercitazione-week1";
            fWather.Filter = "*.txt";
            fWather.NotifyFilter = NotifyFilters.CreationTime| NotifyFilters.LastWrite |
                NotifyFilters.LastAccess | NotifyFilters.FileName
                | NotifyFilters.DirectoryName;
            fWather.EnableRaisingEvents = true;
            fWather.Created += Manager.HandleFile;
            Console.WriteLine("Attendiamo finchè non ti stanchi\n");
            while (Console.ReadLine() != "Basta") ;
            int str = 0;
            while (str != -1) { str = Manager.SchermoMenu(fWather.Path+@"\spese.txt"); Console.WriteLine("Sono nel fottuto handle di merda!DB!\n"); }
        }
    }
}
