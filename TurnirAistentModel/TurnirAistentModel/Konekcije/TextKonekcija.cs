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
        private const string OsobeDatoteke = "OsobaModeli.csv";

        public List<OsobaModel> DobiOsobu_Sve()
        {
            return OsobeDatoteke.CijeliPutPodataka().UcitajDatoteku().PretvoriUOsobaModel();
        }

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

        public OsobaModel StvoriOsobu(OsobaModel model)
        {
            List<OsobaModel> osobe = OsobeDatoteke.CijeliPutPodataka().UcitajDatoteku().PretvoriUOsobaModel();

            int currentID = 1;

            if(osobe.Count > 0)
            {
                currentID = osobe.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentID;

            osobe.Add(model);

            osobe.SpremiUOsobaDatoteke(OsobeDatoteke);

            return model;
        }
    }
}
