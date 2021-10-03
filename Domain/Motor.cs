using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Motor
    {
        public string Nombre { get; set; }
        public Motor() { }
        public Motor (string _nombre)
        {
            Nombre = _nombre;
        }

    }
}
