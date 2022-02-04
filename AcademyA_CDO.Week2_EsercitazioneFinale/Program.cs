using AcademyA_CDO.Week2_EsercitazioneFinale.Library.Entities;
using System;

namespace AcademyA_CDO.Week2_EsercitazioneFinale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continua = true;



            while (continua)
            {
                int scelta = SchermoMenu();
                continua = AnalizzaScelta(scelta);
            }



            int SchermoMenu()
            {
                Console.WriteLine("***************Menu**************");



                Console.WriteLine("\nGestione Magazzino");
                Console.WriteLine("1.Crea nuovo magazzino");
                Console.WriteLine("2.Inserire tipo di merce da ricevere");
                Console.WriteLine("3.Stampa Dati Magazzino");
                Console.WriteLine("4.Visualizza Merci in giacenza");

                Console.WriteLine("\n0.Exit");
                Console.WriteLine("**********************************");



                int scelta;
                Console.WriteLine("Inserisci la tua scelta: ");
                while (!(int.TryParse(Console.ReadLine(), out scelta) && scelta >= 0 && scelta <= 4))
                {
                    Console.WriteLine("Scelta errata. Inserisci una scelta corretta: ");
                }
                return scelta;
            }



            bool AnalizzaScelta(int scelta)
            {
                switch (scelta)
                {
                    case 1:
                        CreaNuovoMagazzino();
                        break;
                    case 2:
                        InserisciMerceDaRicevere();
                        break;
                    case 3:
                        StampaDatiMagazzino();
                        break;
                    case 4:
                        VisualizzaMerciInGiacenza();
                        break;
                    case 0:
                        return false;
                    default:
                        break;
                }
                return true;



                void CreaNuovoMagazzino()
                {
                    //chiedo all'utente i dati per creare un nuovo magazzino
                    Console.WriteLine("Inserisci l'id: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Inserisci l'indirizzo ");
                    string indirizzo = Console.ReadLine();











                }



                void InserisciMerceDaRicevere()
                {




                }
            }
        }

        private static void VisualizzaMerciInGiacenza()
        {
            throw new NotImplementedException();
        }

        private static void StampaDatiMagazzino()
        {
            throw new NotImplementedException();
        }
    }
}
