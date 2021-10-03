using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Parlante
    {
        string Nombre { get; set; }
        public Parlante() { }
        public Parlante (string _nombre)
        {
            Nombre = _nombre;
        }
    }
}
