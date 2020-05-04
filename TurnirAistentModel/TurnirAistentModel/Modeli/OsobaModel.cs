using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnirAistentModel.Modeli
{
    public class OsobaModel
    {
        /// <summary>
        /// Ime jednog člana jedne kipe
        /// </summary>
        public string Ime { get; set; }
        /// <summary>
        /// Prezime tog istog člana
        /// </summary>
        public string Prezime { get; set; }
        /// <summary>
        /// Email adresa tog istog člana
        /// </summary>
        public string EmailAdresa { get; set; }
        /// <summary>
        /// Broji mobitela tog istog člana
        /// </summary>
        public string BrojMobitela { get; set; }
    }
}
