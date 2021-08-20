using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediSupp
{
    class AktivBetegAdatok  
    {
        public string aktivbetegtajszam;
        public string aktivbetegfelvetelido;        
        public string betegpanasza;
        public string kezeles;

        public AktivBetegAdatok(string aktivbetegtajszam, string aktivbetegfelvetelido,string betegpanasza,string kezeles)

        {
            this.aktivbetegtajszam = aktivbetegtajszam;
            this.aktivbetegfelvetelido = aktivbetegfelvetelido;
            this.betegpanasza = betegpanasza;
            this.kezeles = kezeles;

        }
    }
}
