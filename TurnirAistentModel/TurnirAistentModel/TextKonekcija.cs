﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnirAistentModel
{
    public class TextKonekcija : IKonekcija
    {
        // TODO - Spoji StvoriNagradu u text datoteku
        public NagradaModel StvoriNagradu(NagradaModel model)
        {
            model.Id = 1;

            return model;
        }
    }
}
