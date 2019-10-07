using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculatrice
{
    public class NouveauResultatEventArgs:EventArgs
    {
        public string Message { get; set; }
        public string Resultats { get; set; }
    }
}
