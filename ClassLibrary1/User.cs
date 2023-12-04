using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    internal class User : Persona
    {
        public User(string nombre, string apellido, string direccion) : base(nombre, apellido, direccion)
        {
        }
    }
}
