using System;
using System.Collections.Generic;
using System.Text;

namespace KlasePodataka
{
    public class Proizvodjac
    {
        //atributi
        private string pIDProizvodjaca;
        private string pNazivProizvodjaca;
        private string pTip;

        //konstruktor

         public Proizvodjac()
        {
            pIDProizvodjaca = "";
            pNazivProizvodjaca = "";
            pTip = "";
        }

        //javne metode
         public string IDProizvodjaca
         {
             get { return pIDProizvodjaca; }
             set { pIDProizvodjaca = value; }
         }

         public string NazivProizvodjaca
         {
             get { return pNazivProizvodjaca; }
             set { pNazivProizvodjaca = value; }
         }

         public string Tip
         {
             get { return pTip; }
             set { pTip = value; }
         }


    }
}
