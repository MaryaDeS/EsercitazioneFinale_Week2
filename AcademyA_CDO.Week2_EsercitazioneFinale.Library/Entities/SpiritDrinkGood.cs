using System;
using System.Collections.Generic;
using System.Text;

namespace AcademyA_CDO.Week2_EsercitazioneFinale.Library.Entities
{
    public class SpiritDrinkGood:Good, IGood
    {
        private string _goodType;

        public Tipi Tipo { get; set; }
        public float GradazioneAlcolica { get; set; }

        public string GoodType { get => _goodType; }

        public SpiritDrinkGood(int idMerce, string descrizione, decimal prezzo, DateTime dataRicevimento, int quantitàGiacenza, Tipi tipo, float gradazioneAlcolica) : base(idMerce, descrizione, prezzo, dataRicevimento, quantitàGiacenza)
        {
            Tipo = tipo;
            GradazioneAlcolica = gradazioneAlcolica;    
        }

        public override string ToString()
        {
            return base.ToString()+ $"Tipo: {Tipo} - GradazioneAlcolica: {GradazioneAlcolica}";
        }


    }
}
