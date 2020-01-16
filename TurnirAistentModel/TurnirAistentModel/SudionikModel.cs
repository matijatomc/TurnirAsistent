using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnirAistentModel
{
    public class SudionikModel
    {
        /// <summary>
        /// Ekipa koja sudjeluje u utakici
        /// </summary>
        public EkipaModel NatjecateljskaEkipa { get; set; }
        /// <summary>
        /// Rezultat ove ekipe u utakmici
        /// </summary>
        public double Rezultat { get; set; }
        /// <summary>
        /// Prethodna utaklica u kojoj je ova ekipa bila pobjednik 
        /// </summary>
        public UtakmicaModel PrethodnaUtakmica { get; set; }

    }
}
