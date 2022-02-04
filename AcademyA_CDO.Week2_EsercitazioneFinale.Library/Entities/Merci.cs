using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AcademyA_CDO.Week2_EsercitazioneFinale.Library.Entities
{
    public class Merci<T> : IEnumerable<T>
    {
        internal List<T> MerciInGiacenza { get; set; }

        public Merci()
        {
            MerciInGiacenza = new List<T>();
        }
        public void Add(T prodottoToAdd)
        {
            if (prodottoToAdd.Equals(default(T)))
                return;
            MerciInGiacenza.Add(prodottoToAdd);
        }
        public void Add(List<T> listToAdd)
        {
            if (listToAdd.Equals(default(List<T>)))
                return;
            MerciInGiacenza.AddRange(listToAdd);
        }


        public IEnumerator<T> GetEnumerator()
        {
            foreach (var mer in MerciInGiacenza)
                yield return mer;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

       
    }
}
