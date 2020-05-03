using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnirAistentModel
{
    public class SqlKonekcija : IKonekcija
    {
        // TODO - Dovrši metodu StvoriNagradu, za sad ne sprema niš
        /// <summary>
        /// Spremi novu nagradu u bazu podataka
        /// </summary>
        /// <param name="model">Informacija nagrade</param>
        /// <returns>Informaciju nagrade i id nagrade</returns>
        public NagradaModel StvoriNagradu(NagradaModel model)
        {
            model.Id = 1;

            return model;
        }
    }
}
