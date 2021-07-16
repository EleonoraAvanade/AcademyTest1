using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1_AC_Esercitazione.Chain_Of_Responsability;
using Week1_AC_Esercitazione.Factory;
using Week1_AC_Esercitazione.Factory.Categorie;

namespace Week1_AC_Esercitazione
{
    public static class Manager
    {
        public static void HandleFile(object sender, FileSystemEventArgs f)
        {
            Console.WriteLine("Il file {0} è stato creato, finally!\n", f.Name);
            Console.WriteLine("Adesso puoi scriverci o leggerci!\n");
        }

        public static int SchermoMenu(string f)
        {
            Console.WriteLine("Sono nel fottuto Schermomenu di merda!DB!\n");
            Console.WriteLine("1 - Leggi\n2 - Scrivi\n3 - Esci\n");
                int inp = 0;
                while(!Int32.TryParse(Console.ReadLine(), out inp))
                    Console.WriteLine("1 - Leggi\n2 - Scrivi\n3 - Esci\n");
                switch (inp)
                {
                    case 1:
                        Leggi(f);
                        break;
                    case 2:
                        Scrivi(f);
                        break;
                    case 3:
                        return -1;
                    default:
                        Console.WriteLine("Inserisci un numero tra quelli!\n");
                        break;
                }
            return 1;
        }

        private static void Scrivi(string f)
        {
            Console.WriteLine("Sono nel fottuto scrivi di merda!DB!\n");
            Console.WriteLine("Immetti la data: \n");
            DateTime date;
            while (!DateTime.TryParse(Console.ReadLine(), out date))
            {
                Console.WriteLine("Immetti la data: (yyyy-mm-gg)\n");
            }
            Console.WriteLine("Immetti l'importo\n");
            int importo;
            while (!Int32.TryParse(Console.ReadLine(), out importo))
            {
                Console.WriteLine("Immetti l'importo\n");
            }
            string LivAppr = "Bo";
            while ((!LivAppr.Contains("Manager")) || (!LivAppr.Contains( "Op")) || (!LivAppr.Contains ("CEO")))
            {
                Console.WriteLine("Immetti se è di tipo Manager, Op oppure CEO\n");
                LivAppr = Console.ReadLine();
            }
            Console.WriteLine("Chain of Responsability\n");
            var manager = new ManagerHandler();
            var op = new OperationalManagerHandler();
            var CEO = new CEOHandler();
            var notApproved = new NotApproved();
            manager.SetNext(op).SetNext(CEO).SetNext(notApproved);
            Spesa spesa = new Spesa();
            spesa.data = date;
            spesa.Importo = importo;
            spesa.LivApprov = LivAppr;
            string res = manager.Handle(importo);
            if (res.Contains("manager") && LivAppr == "Manager") spesa.Descrizione = "Approvata";
            if (res.Contains("operation") && LivAppr == "Op") spesa.Descrizione = "Approvata";
            if (res.Contains("CEO") && LivAppr == "CEO") spesa.Descrizione = "Approvata";
            else spesa.Descrizione = "Non approvata";
            RimborsoFactory rimborsoFactory = new RimborsoFactory();
            IRimborso rimborso=null;
            if (spesa.Descrizione!="Non approvata")
            {
                string Categoria ="-";
                while ((Categoria != "Viaggio") || (Categoria != "Alloggio") || (Categoria != "Vitto")|| (Categoria != "Altro"))
                {
                    Console.WriteLine("Immetti se è di tipo Viaggio, Vitto, Alloggio oppure Altro\n");
                    Categoria = Console.ReadLine();
                }
                spesa.Categoria = Categoria;
                rimborso=rimborsoFactory.GetRimborso(Categoria);
            }
            try
            {
                using (StreamWriter writer = File.CreateText(f))
                {
                    writer.Write(spesa);
                    if (rimborso != null) writer.WriteLine(rimborso);
                    else Console.WriteLine("\n");
                }
            }
            catch (IOException ioe)
            {
                Console.WriteLine(ioe.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void Leggi(string f)
        {
            Console.WriteLine("Sono nel fottuto LEGGi di merda!DB!\n");
            try
            {
                using (StreamReader r = File.OpenText(f))
                {
                    Console.WriteLine("Il contenuto attuale del file è:\n");
                    string riga = r.ReadLine();
                    while (riga != null)
                    {
                        Console.WriteLine(riga);
                        riga = r.ReadLine();
                    }
                    Console.WriteLine("EOF\n");
                }
                Console.WriteLine("Letto!\n");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
