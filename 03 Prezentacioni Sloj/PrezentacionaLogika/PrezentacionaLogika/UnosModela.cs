using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using KlasePodataka;

namespace PrezentacionaLogika
{
    public class UnosModela
    {
        // atributi
        private string pStringKonekcije;
        private string pIDModela;
        private string pNazivModela;
        private string pMotor;
        private string pGodina;

        
        private string pNazivBoje;
        private string pNazivProizvodjaca;

        public string StringKonekcije
        {
            get { return pStringKonekcije; }
            set { pStringKonekcije = value; }
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
        

        public string NazivBoje
        {
            get { return pNazivBoje; }
            set { pNazivBoje = value; }
        }
        

        public string NazivProizvodjaca
        {
            get { return pNazivProizvodjaca; }
            set { pNazivProizvodjaca = value; }
        }


        // konstruktor
        public UnosModela(string NoviStringKonekcije)
        {
            pStringKonekcije = NoviStringKonekcije;
        }

        // public metode
        public DataSet DajPodatkeZaCombo()
        {
            DataSet dsPodaci = new DataSet();
           ProizvodjacDB objProizvodjacDB = new ProizvodjacDB(pStringKonekcije);
            //BojeDB objBojeDB = new BojeDB(pStringKonekcije);

           dsPodaci = objProizvodjacDB.DajSveProizvodjace();
            //dsPodaci = objBojeDB.DajSveBoje();
            return dsPodaci;
        }

      
        public DataSet DajPodatkeZaBoju()
        {
            DataSet dsPodaciBoja= new DataSet();
           
            BojeDB objBojeDB = new BojeDB(pStringKonekcije);

            dsPodaciBoja = objBojeDB.DajSveBoje();

            return dsPodaciBoja;
        }

        public bool DaLiSuPodaciIspravni()
        {
            // BAZICNA PROVERA ISPRAVNOSTI PODATAKA
            // osnovna validacija podataka
            bool IspravniPodaci = true;

            //- DA LI JE SVE POPUNJENO
            if ((this.pIDModela.Equals("")) || (this.pMotor.Equals("")) || (this.pNazivModela.Equals("")) || (this.pNazivBoje.Equals("")) || (this.pNazivProizvodjaca == null))
            {
                IspravniPodaci = false;
            }
            else
            {


                //- DA LI ODGOVARA DUZINA UNETE VREDNOSTI
                if (this.pIDModela.Length > 10)
                {
                    IspravniPodaci = false;
                }
                else
                {
                    ModelDB objModelDB = new ModelDB(this.pStringKonekcije);
                    DataSet dsPodaciModela = objModelDB.DajSveModelePoID(this.pIDModela);
                    bool NePostojiSifraUBazi = (dsPodaciModela.Tables[0].Rows.Count == 0);
                    IspravniPodaci = NePostojiSifraUBazi;

                }

            }
            return IspravniPodaci;
        }

        public string DajSifruProizvodjaca(string NazivProizvodjaca)
        {
            string VrednostSifreProizvodjaca = "";
            // citanje podataka iz clsRobaDB
            ProizvodjacDB objRobaDB = new ProizvodjacDB(pStringKonekcije);
            DataSet dsPodaci = new DataSet();
            dsPodaci = objRobaDB.DajProizvodjacaPoNazivu(NazivProizvodjaca);
            VrednostSifreProizvodjaca = dsPodaci.Tables[0].Rows[0].ItemArray[0].ToString();
            return VrednostSifreProizvodjaca;
        }

        public string DajSifruBoje(string NazivBoje)
        {
            string VrednostSifreBoje = "";
            // citanje podataka iz clsRobaDB
            BojeDB objRBojaDB = new BojeDB(pStringKonekcije);
            DataSet dsPodaciBoja = new DataSet();
            dsPodaciBoja = objRBojaDB.DajBojuPoNazivu(NazivBoje);
            VrednostSifreBoje = dsPodaciBoja.Tables[0].Rows[0].ItemArray[0].ToString();
            return VrednostSifreBoje;
        }

        public bool SnimiPodatke()
        {
            ProveraOpseg.Service1 service = new ProveraOpseg.Service1();
            bool uspeh = false;
            if (this.DaLiSuPodaciIspravni())
            {
                if (service.ProveriOpseg(Int32.Parse(pMotor)))
                {
                    ModelDB objModelDB = new ModelDB(pStringKonekcije);
                    Model objNoviModel = new Model();
                    // prerada ulaznih podataka
                    objNoviModel.IDModela = pIDModela;
                    objNoviModel.NazivModela = pNazivModela;
                    objNoviModel.Motor = pMotor;
                    objNoviModel.Godina = pGodina;
                    objNoviModel.SifraBoje = this.DajSifruBoje(this.pNazivBoje);
                    objNoviModel.SifraProizvodjaca = this.DajSifruProizvodjaca(this.pNazivProizvodjaca);


                    // snimanje putem DB klase
                    uspeh = objModelDB.SnimiNoviModel(objNoviModel);
                }
            }
            return uspeh;
        }

      


    }
}
