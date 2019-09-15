using System;
using System.Collections.Generic;
using System.Text;

namespace KlasePodataka
{
    public class Boje
    {
        private string pIDBoje;
        private string pNazivBoje;

          //konstruktor

        public Boje()
        {
            pIDBoje = "";
            pNazivBoje = "";
        }

        public string IDBoje
        {
            get { return pIDBoje; }
            set { pIDBoje = value; }
        }

        public string NazivBoje
        {
            get { return pNazivBoje; }
            set { pNazivBoje = value; }
        }

    }
}
