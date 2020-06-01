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
        public static IKonekcija Konekcija { get; private set; }

        public static void ZapoceteKonekcije(TipBazePodatak db)
        {
            if (db == TipBazePodatak.Sql)
            {
                // TODO - Spojit sql pravilno
                SqlKonekcija sql = new SqlKonekcija();
                Konekcija = sql;
            }
            else if (db == TipBazePodatak.TextDatoteka)
            {
                // TODO - Spojit text
                TextKonekcija text = new TextKonekcija();
                Konekcija = text;
            }
        }
        
        public static string KonekcijaString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
