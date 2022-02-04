using System;
using System.Collections.Generic;
using System.Text;

namespace AcademyA_CDO.Week2_EsercitazioneFinale.Library.Entities
{
    public class PerishableGood:Good, IGood
    {
        private string _goodType;

        public DateTime DataDiScadenza { get; set; }
        public ModalitàConservazione Modalità{ get; set; }
        public string GoodType { get => _goodType; }

        public PerishableGood(int idMerce, string descrizione, decimal prezzo, DateTime dataRicevimento, int quantitàGiacenza, ModalitàConservazione modalità, DateTime dataScadenza) : base(idMerce, descrizione, prezzo, dataRicevimento, quantitàGiacenza)
        {
            DataDiScadenza = dataScadenza;
            Modalità = modalità;
        }

        public override string ToString()
        {
            return base.ToString()+ $"DataScadenza: {DataDiScadenza} - Modalità: {Modalità}";
        }

    }
}
