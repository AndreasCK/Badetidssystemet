using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badetidssystemet
{
    class Badetidsperiode 
    {
        Dictionary<string, Kreds> ID = new Dictionary<string, Kreds>();
        private string _type;
        private DayOfWeek _ugedag;
        private DateTime _Starttidspunkt;
        private DateTime _Sluttidspunkt;

        public Badetidsperiode()
        {

            ID = new Dictionary<string, Kreds>();
        }

        public string Type { get; set; }
        public DayOfWeek UgeDag { get; set; }
        public DateTime Starttidspunkt { get; set; }
        public DateTime Sluttidspunkt { get; set; }

        public Badetidsperiode(string type, DayOfWeek ugedag, DateTime starttidspunkt, DateTime sluttidspunkt)
        {
            Type = type;
            UgeDag = ugedag;
            Starttidspunkt = starttidspunkt;
            Sluttidspunkt = sluttidspunkt;

            try
            {
                if (Starttidspunkt > Sluttidspunkt)
                {
                    ArgumentException Advarsel = new ArgumentException("Sluttidspunktet kan ikke være før starttidspunktet");
                    throw Advarsel;

                }
            }
            catch 
            {
                Console.WriteLine("Sluttidspunktet kan ikke være før starttidspunktet");
            }

        }

      


        public void AdderKreds(Kreds kreds)
        {
            ID.Add(kreds.ID, kreds);
        }

       public void SletKreds(Kreds id)
        {
            ID.Remove(id.ID);
        }
        public override string ToString()
        {
            return $"{Type} sker på {UgeDag} starter d. {Starttidspunkt} og slutter d. {Sluttidspunkt}";
        }






    }
}
