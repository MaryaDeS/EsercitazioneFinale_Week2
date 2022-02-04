using System;
using System.Collections.Generic;
using System.Text;

namespace AcademyA_CDO.Week2_EsercitazioneFinale.Library.Entities
{
    public class ElectronicGood:Good, IGood
    {
        private string _goodType;

        
        public string Produttore { get; set; }
        public string GoodType { get =>  _goodType; }

       

        public ElectronicGood(int idMerce, string descrizione, decimal prezzo, DateTime dataRicevimento, int quantitàGiacenza, string produttore) : base(idMerce, descrizione, prezzo, dataRicevimento, quantitàGiacenza)
        {
            Produttore = produttore;
        }

        

        public override string ToString()
        {
            return base.ToString() + $"Produttore: {Produttore}";
        }

       
    }
}
