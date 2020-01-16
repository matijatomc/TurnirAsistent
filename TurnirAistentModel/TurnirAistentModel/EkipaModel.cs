using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnirAistentModel
{
    public class EkipaModel
    {
        /// <summary>
        /// Lista članova ove ekipe
        /// </summary>
        public List<OsobaModel> ClanoviEkiope { get; set; } = new List<OsobaModel>();
        /// <summary>
        /// Naziv ove ekipe
        /// </summary>
        public string ImeEkipe { get; set; }

    }
}
