using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnirAistentModel.Modeli;

namespace TurnirAistentModel.Konekcije
{
    public interface IKonekcija
    {
        NagradaModel StvoriNagradu(NagradaModel model);
        OsobaModel StvoriOsobu(OsobaModel model);
    }
}
