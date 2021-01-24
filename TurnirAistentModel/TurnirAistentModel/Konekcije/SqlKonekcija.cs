using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnirAistentModel.Modeli;


namespace TurnirAistentModel.Konekcije
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
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.KonekcijaString("TurnirBaza")))
            {
                var p = new DynamicParameters();
                p.Add("@osvojenoMjesto", model.OsvojenoMjesto);
                p.Add("@nazivMjesta", model.NazivMjesta);
                p.Add("@iznosNagrade", model.IznosNagrade);
                p.Add("@postotakNagrade", model.PostotakNagrade);
                p.Add("@ID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spNagrada_Upis", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@ID");

                return model;
            }
        }

        public OsobaModel StvoriOsobu(OsobaModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.KonekcijaString("TurnirBaza")))
            {
                var p = new DynamicParameters();
                p.Add("@ime", model.Ime);
                p.Add("@prezime", model.Prezime);
                p.Add("@email", model.EmailAdresa);
                p.Add("@brojMobitela", model.BrojMobitela);
                p.Add("@ID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spOsoba_Upis", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@ID");

                return model;
            }
        }
    }
}
