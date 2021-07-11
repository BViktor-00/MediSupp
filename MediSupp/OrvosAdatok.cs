using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediSupp
{
    public class OrvosAdatok
    {
        public int ID;
        public string nev;
        public string szakterulet;
        public string emailcim;
        public string betegek;
        public string orvospecset;

        public OrvosAdatok(int ID, string nev, string szakterulet, string emailcim, string orvospecset, string betegek)
        {
            this.ID = ID;
            this.nev = nev;
            this.szakterulet = szakterulet;
            this.emailcim = emailcim;
            this.orvospecset = orvospecset;
            this.betegek = betegek;
        }

    }
}
