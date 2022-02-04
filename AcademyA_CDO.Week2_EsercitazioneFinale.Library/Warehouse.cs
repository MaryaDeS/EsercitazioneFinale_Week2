using AcademyA_CDO.Week2_EsercitazioneFinale.Library.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AcademyA_CDO.Week2_EsercitazioneFinale.Library
{
    public class Warehouse
    {
        public Guid IdMagazzino { get; set; }
        public string Indirizzo { get; set; }
        public int MerceInGiacenza { get; set; }
        public DateTime DataUltimaOperazione { get; set; }


        public Warehouse()
        {

            IdMagazzino = Guid.NewGuid();
        }


        public Warehouse AddGood(Good good)
        {
            //throw new NotImplementedException();
            //qui fare un metodo che controlli se la lista delle Merci, nel caso mi deve dire che è vuota
            //poi aggiungere la merce alla lista
            return new Warehouse();
        }

        private Warehouse RemoveGood(Good good)
        {
            throw new NotImplementedException();
        }

        public Warehouse(string indirizzo, int merceInGiacenza, DateTime dataUltimaOperazione)
        {
            Indirizzo = indirizzo;
            MerceInGiacenza = merceInGiacenza;
            DataUltimaOperazione = dataUltimaOperazione;
        }




        #region Overload metodi
        public static Warehouse operator +(Warehouse warehouse, Good good)
        {
            return warehouse.AddGood(good);
        }

        public static Warehouse operator -(Warehouse warehouse, Good good)
        {
            return warehouse.RemoveGood(good);
        }

        public void StockToList(Warehouse warehouse, Good good)
        {
            Console.WriteLine("Dati Magazzino: ", warehouse.IdMagazzino, warehouse.Indirizzo, warehouse.MerceInGiacenza, good.ToString());
        }
        



        #endregion
    }

    }


