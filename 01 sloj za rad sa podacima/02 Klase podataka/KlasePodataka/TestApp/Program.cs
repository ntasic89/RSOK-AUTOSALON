using System;
using System.Collections.Generic;
using System.Text;
using KlasePodataka;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ProizvodjacDB proizvodjac = new ProizvodjacDB();
           
            //var data = proizvodjac.DajSveProizvodjace().Tables[0].Rows[0].ItemArray[2].ToString();

            ModelDB model = new ModelDB();
            var data = model.DajSveModele().Tables[0].Rows[0].ItemArray[2].ToString();    
        }
    }
}
