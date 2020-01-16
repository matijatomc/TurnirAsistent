using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnirAistentModel
{
    public class NagradaModel
    {
        /// <summary>
        /// Osvojeno mjesto neke ekipe
        /// </summary>
        public int OsvojenoMjesto { get; set; }
        /// <summary>
        /// Naziv mjesta koje je neka ekipa osvojila 
        /// </summary>
        public string NazivMjesta { get; set; }
        /// <summary>
        /// Iznos nagrade koju je neka ekipa osvojila
        /// </summary>
        public decimal  IznosNagrade { get; set; }
        /// <summary>
        /// Postotak nagrade koju turnir zaradio od kotizacije
        /// </summary>
        public double PostotakNagrade { get; set; }
    }
}
