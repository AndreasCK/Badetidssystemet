using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badetidssystemet
{
    class Main
    {
        public void Minkode()
        {
           

            DateTime tid1 = new DateTime().AddYears(2022).AddMonths(10).AddDays(12).AddHours(8).AddMinutes(20);
            DateTime tid2 = new DateTime().AddYears(2022).AddMonths(10).AddDays(12).AddHours(12).AddMinutes(20);
            DateTime tid3 = new DateTime().AddYears(2022).AddMonths(10).AddDays(13).AddHours(9).AddMinutes(20);
            DateTime tid4 = new DateTime().AddYears(2022).AddMonths(10).AddDays(13).AddHours(12).AddMinutes(20);


            Badetidsperiode Periode = new Badetidsperiode();
            Kreds a1 = new Kreds("Første kreds", "badetur", "Søen", 18, "Torben",8);
            Kreds a2 = new Kreds("Anden kreds", "badetur", "Søen", 32, "Anders",9);
            Kreds a3 = new Kreds("tredje kreds", "badetur", "Søen", 32, "Hans",10);
            Kreds a4 = new Kreds("fjedre", "badetur", "Søen", 32, "Jacob",11);


            Badetidsperiode d1 = new Badetidsperiode("første kreds", DayOfWeek.Monday, tid2, tid1);
            Badetidsperiode d2 = new Badetidsperiode("anden kreds", DayOfWeek.Friday, tid3, tid4);
          

            Periode.AdderKreds(a3);
            Periode.AdderKreds(a4);
            Periode.SletKreds(a3);


            Console.WriteLine(a1);
            Console.WriteLine(a2);

            Console.WriteLine();
            Console.WriteLine(d1);
            
            
            Console.WriteLine(d2);



        }
    }
}
