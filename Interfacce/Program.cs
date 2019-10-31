using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfacce
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona 
            {
                Name = "Pippo",
                Surname = "Baudo",
                BirthDay = new DateTime(1936, 12, 7),
                RAL = 350000
            };

            //Persona p2 = (Persona)p1.Clone();

            //Persona p3 = new Persona
            //{
            //    Name = "Ezio",
            //    Surname = "Greggio",
            //    BirthDay = new DateTime(1954, 4, 7)
            //};

            try
            {
                //Console.WriteLine("{0} {1} è più vecchio di {2} {3}?: {4}!",
                //    p1.Name, 
                //    p1.Surname, 
                //    p3.Name, 
                //    p3.Surname,
                //    p1.CompareTo(p3) < 0 ? "Sì" : "No");

                //string stringa = string.Format("{0:NC} ha un RAL di {1}, corrispondente a {2:C3}/mese. " +
                //                                "{0:N} ha {3} mensilità. {0:C} è nato: {4:d}",
                //    p1,
                //    p1.RAL.ToString("C3", CultureInfo.CreateSpecificCulture("en-US")),
                //    p1.GetMensilità(),
                //    p1.mensilità,
                //    p1.BirthDay);
                //Console.WriteLine(stringa);


                Console.WriteLine("{0}", p1);

                Console.WriteLine(p1.ToString());
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            
            Console.WriteLine(p1.Name + p1.GetAge());

            Console.ReadLine();
        }
    }
}
