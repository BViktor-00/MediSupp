using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediSupp
{
    public class OrvosAdatok
    {
        private int _ID;
        private string _nev;
        private string _szakterulet;
        private string _emailcim;
        private string _betegek;
        private string _orvospecset;



        public int ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (value > 0) _ID = value;
                else throw new Exception("Az ID értéke csak pozitív lehet!");
            }
        }

        public string nev
        {
            get
            {
                return _nev;
            }
            set
            {
                if (value.Length <= 50) _nev = value;
                else throw new Exception("A megadott szakterulet nem megfelelő!");
            }
        }
        public string szakterulet
        {
            get
            {
                return _szakterulet;
            }
            set
            {
                if (value.Length <= 50) _szakterulet = value;
                else throw new Exception("A megadott szakterulet nem megfelelő!");
            }
        }

        public string emailcim
        {
            get
            {
                return _emailcim;
            }
            set
            {
                if (value.Length <= 60) _emailcim = value;
                else throw new Exception("A megadott név nem megfelelő!");
            }
        }

        public string orvospecset
        {
            get
            {
                return _orvospecset;
            }
            set
            {
                if (value.Length == 6) _orvospecset = value;
                else throw new Exception("A megadott pecsétszám hossza nem megfelelő!");
            }
        }

        public string betegek
        {
            get
            {
                return _betegek;
            }
            set
            {

            }  
        }


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
