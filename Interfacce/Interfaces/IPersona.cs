using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfacce.Interfaces
{
    interface IPersona
    {
        string Name { get; set; }
        string Surname { get; set; }
        DateTime BirthDay { get; set; }
        int GetAge();
    }
}
