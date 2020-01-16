using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnirAistentModel
{
    public class TurnirModel
    {
        /// <summary>
        /// Naziv trenutačnog turnira
        /// </summary>
        public string NazivTurnira { get; set; }
        /// <summary>
        /// Iznos kotizacije koji svaki tim treba platit
        /// </summary>
        public decimal Kotizacija { get; set; }
        /// <summary>
        /// Lista svih prijavljenih timova u turniru
        /// </summary>
        public List<EkipaModel> PrijavljeniTimovi { get; set; } = new List<EkipaModel>();
        /// <summary>
        /// Lista svih mogučih nagrada
        /// </summary>
        public List<NagradaModel> Nagrada { get; set; } = new List<NagradaModel>();
        /// <summary>
        /// Lista rundi u kojoj je lista svih utakmica u toj rundi
        /// </summary>
        public List<List<UtakmicaModel>> Runde { get; set; } = new List<List<UtakmicaModel>>();
    }
}
