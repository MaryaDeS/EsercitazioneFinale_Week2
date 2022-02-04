using System;
using System.Collections.Generic;
using System.Text;

namespace AcademyA_CDO.Week2_EsercitazioneFinale.Library.Entities
{
    public class Good
    {
        public int IdMerce { get; set; }
        public string Descrizione { get; set; }
        public decimal Prezzo { get; set; }
        public DateTime DataRicevimento { get; set; }
        public int QuantitàInGiacenza { get; set; }
        public IList<Good> GoodList { get; set; } = new List<Good>();


        public Good(int idMerce, string descrizione, decimal prezzo, DateTime dataRicevimento, int quantitàGiacenza)
        {
            IdMerce = idMerce;
            Descrizione = descrizione;
            Prezzo = prezzo;
            DataRicevimento = dataRicevimento;
            quantitàGiacenza = QuantitàInGiacenza;


        }

        public override string ToString()
        {
            return $"ID: {IdMerce} - Descrizione: {Descrizione} - Prezzo: {Prezzo} - DataRicevimento: {DataRicevimento} - QuantitàInGiancenza: {QuantitàInGiacenza}";
        }
    }
}
