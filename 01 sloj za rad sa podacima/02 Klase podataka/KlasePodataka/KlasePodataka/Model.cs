using System;
using System.Collections.Generic;
using System.Text;

namespace KlasePodataka
{
   public class Model
    {
        //atributii
        private string pIDModela;
        private string pNazivModela;
        private string pMotor;
        private string pGodina;
        private string pSifraBoje;
        private string pSifraProizvodjaca;

        //konstruktor

        public Model()
        {
            pIDModela = "";
            pNazivModela = "";
            pMotor = "";
            pGodina = "";
            pSifraBoje = "";
            pSifraProizvodjaca = "";
        }

        public string IDModela
        {
            get { return pIDModela; }
            set { pIDModela = value; }
        }

        public string NazivModela
        {
            get { return pNazivModela; }
            set { pNazivModela = value; }
        }

        public string Motor
        {
            get { return pMotor; }
            set { pMotor = value; }
        }

        public string Godina
        {
            get { return pGodina; }
            set { pGodina = value; }
        }

        public string SifraBoje
        {
            get { return pSifraBoje; }
            set { pSifraBoje = value; }
        }

        public string SifraProizvodjaca
        {
            get { return pSifraProizvodjaca; }
            set { pSifraProizvodjaca = value; }
        }
        
    }
}
