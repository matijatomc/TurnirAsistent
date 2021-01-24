using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnirAistentModel.Modeli;

namespace TurnirAistentModel.Konekcije.TextPomagaci
{
    public static class TextKonekcijeProcesor
    {
        public static string CijeliPutPodataka(this string imeDatoteke)
        {
            return $"{ ConfigurationManager.AppSettings["putDatoteka"] }\\{ imeDatoteke }";
        }

        public static List<string> UcitajDatoteku(this string datoteka)
        {
            if (!File.Exists(datoteka))
            {
                return new List<string>();
            }
            return File.ReadAllLines(datoteka).ToList();
        }

        public static List<NagradaModel> PretvoriUNagradaModel(this List<string> lines)
        {
            List<NagradaModel> output = new List<NagradaModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                NagradaModel p = new NagradaModel();
                p.Id = int.Parse(cols[0]);
                p.OsvojenoMjesto = int.Parse(cols[1]);
                p.NazivMjesta = cols[2];
                p.IznosNagrade = decimal.Parse(cols[3]);
                p.PostotakNagrade = double.Parse(cols[4]);
                output.Add(p);
            }

            return output;
        }

        public static List<OsobaModel> PretvoriUOsobaModel(this List<string> lines)
        {
            List<OsobaModel> output = new List<OsobaModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                OsobaModel p = new OsobaModel();
                p.Id = int.Parse(cols[0]);
                p.Ime = cols[1];
                p.Prezime = cols[2];
                p.EmailAdresa = cols[3];
                p.BrojMobitela = cols[4];
                output.Add(p);
            }

            return output;
        }

        public static void SpremiUNagradaDatoteke(this List<NagradaModel> models, string imeDatoteke)
        {
            List<string> lines = new List<string>();

            foreach (NagradaModel p in models)
            {
                lines.Add($"{ p.Id },{ p.OsvojenoMjesto },{ p.OsvojenoMjesto },{ p.IznosNagrade },{ p.PostotakNagrade }");
            }

            File.WriteAllLines(imeDatoteke.CijeliPutPodataka(), lines);
        } 

        public static void SpremiUOsobaDatoteke(this List<OsobaModel> models, string imeDatoteke)
        {
            List<string> lines = new List<string>();

            foreach (OsobaModel p in models)
            {
                lines.Add($"{ p.Id },{ p.Ime },{ p.Prezime },{ p.EmailAdresa },{ p.BrojMobitela }");
            }

            File.WriteAllLines(imeDatoteke.CijeliPutPodataka(), lines);
        }
    }
}
