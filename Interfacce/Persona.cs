using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfacce.Interfaces;

namespace Interfacce
{
    class Persona : IPersona, ICloneable, IComparable, IFormattable
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDay { get; set; }
        public int RAL { get; set; }
        public readonly double mensilità = 12d;

        public Persona() { }
        public Persona(string name, string surname, DateTime birthDate)
        {
            Name = name;
            Surname = surname;
            BirthDay = birthDate;
        }

        public double GetMensilità()
        {
            return RAL / mensilità;
        }

        public object Clone()
        {
            return new Persona(this.Name, this.Surname, this.BirthDay);
        }

        public int GetAge()
        {
            var timeSpan = DateTime.Now - BirthDay;
            int age = timeSpan.Days / 365;
            return age;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            int result;

            Persona otherPerson = obj as Persona;
            if (otherPerson != null)
            {
                result = BirthDay.CompareTo(otherPerson.BirthDay);
            }
            else
            {
                throw new ArgumentException("L'oggetto da comparare non è una persona");
            }

            return result;
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            var result = string.Empty;

            if (string.IsNullOrEmpty(format))
            {
                result = Name + " " + Surname + " " + BirthDay.ToString("d");
            }
            else if (format == "NC")
            {
                result = Name + " " + Surname;
            }
            else if (format == "N")
            {
                result = Name;
            }
            else if (format == "C")
            {
                result = Surname;
            }
            else
            {
                throw new FormatException("Il formato richiesto non è previsto");
            }

            return result;
        }

        public override string ToString()
        {
            //StringBuilder sb = new StringBuilder("I dettagli della persona sono: ");
            //sb.Append("Nome: " + Name);
            //sb.AppendFormat(" Cognome: {0:C}", this);
            //sb.AppendLine(" Data di Nascita: " + BirthDay.ToString("d"));
            //sb.Append("Età: " + GetAge());

            return string.Format(
                "Nome: {0:N}, " +
                "Cognome: {0:C}, " +
                "Data di nascita: {1}, " +
                "Età: {2}",
                this,
                BirthDay,
                GetAge());
        }
    }
}
