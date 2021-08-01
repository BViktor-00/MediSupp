using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediSupp
{
    class BetegAdatok
    {
        public int id;
        public string betegneve;
        public string betegszulhely;
        public string betegszulido;
        public int betegeletkor;
        public string betegtajszam;
        public string beteginfo;
        public string betegkorelozmeny;

        public BetegAdatok(int id,string betegneve,string betegszulhely,string betegszulido,int betegeletkor,string betegtajszam,string beteginfo,string betegkorelozmeny)
        {
            this.id = id;
            this.betegneve = betegneve;
            this.betegszulhely = betegszulhely;
            this.betegszulido = betegszulido;
            this.betegeletkor = betegeletkor;
            this.betegtajszam = betegtajszam;
            this.beteginfo = beteginfo;
            this.betegkorelozmeny = betegkorelozmeny;
        }

    }
}
