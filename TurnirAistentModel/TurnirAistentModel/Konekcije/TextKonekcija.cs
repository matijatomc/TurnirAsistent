using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnirAistentModel.Modeli;
using TurnirAistentModel.Konekcije.TextPomagaci;

namespace TurnirAistentModel.Konekcije
{
    public class TextKonekcija : IKonekcija
    {

        private const string NagradeDatoteke = "NagradaModeli.csv";

        // TODO - Spoji StvoriNagradu u text datoteku
        public NagradaModel StvoriNagradu(NagradaModel model)
        {
            // Ucitaj text datoteku i pretvori text u List<NagradaModel>
            List<NagradaModel> nagrade = NagradeDatoteke.CijeliPutPodataka().UcitajDatoteku().PretvoriUNagradaModel();

            // Nadi najvecu ID
            int sadasnjiID = 1;

            if (nagrade.Count > 0)
            {
                sadasnjiID = nagrade.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = sadasnjiID;

            // Dodaj novi zapis sa novim ID (max + 1)
            nagrade.Add(model);

            // Pretvori nagradu u list<string>
            // Spremit list<string> u text datoteku
            nagrade.SpremiUNagradaDatoteke(NagradeDatoteke);

            return model;
        }
    }
}
