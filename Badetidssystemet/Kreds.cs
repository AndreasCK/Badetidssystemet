using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badetidssystemet
{
    class Kreds 
    {
        private string _id;
        private string _navn;
        private string _adresse;
        private int _antaldeltagere;
        private string _lejransat;
        private int _Alder;

        public string ID { get; set; }
        public string Navn { get; set; }
        public string Adresse { get; set; }
        public int AntalDeltagere { get; set; }
        public string LejrAnsat { get; set; }
        public int Alder { get; set; }

        public Kreds(string id, string navn, string adresse, int antaldeltagere, string lejransat, int alder)
        {
            ID = id;
            Navn = navn;
            Adresse = adresse;
            AntalDeltagere = antaldeltagere;
            LejrAnsat = lejransat;
            Alder = alder;


            try
            {
                if (AntalDeltagere < 0)
                {
                 ArgumentException Advarsel = new ArgumentException($"Antal Deltagere skal være mere end 0");
                    throw Advarsel;   
                }
            }
            catch (ArgumentException)
            {
                ArgumentException Advarsel = new ArgumentException($"Antal Deltagere skal være mere end 0");
                throw Advarsel;
            }
        }

        public override string ToString()
        {
            return $"{ID} {Navn} med aldersgruppen {Alder} i {Adresse} har følgende antal deltagere {AntalDeltagere} og har lejransat {LejrAnsat}";
        }



    }
}
