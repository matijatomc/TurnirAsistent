using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnirAistentModel.Konekcije;

namespace TurnirAistentModel
{
    public static class GlobalConfig
    {
        public static List<IKonekcija> Konekcije { get; private set; } = new List<IKonekcija>();

        public static void ZapoceteKonekcije(bool bazaPodataka, bool textDatoteke)
        {
            if (bazaPodataka)
            {
                // TODO - Spojit sql pravilno
                SqlKonekcija sql = new SqlKonekcija();
                Konekcije.Add(sql);
            }
            if (textDatoteke)
            {
                // TODO - Spojit text
                TextKonekcija text = new TextKonekcija();
                Konekcije.Add(text);
            }
        }
        
        public static string KonekcijaString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
