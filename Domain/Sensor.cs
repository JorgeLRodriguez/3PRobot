using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Sensor
    {
        public string Nombre { get; set; }
        public bool Lectura { get; set; }
        public Sensor(){}
        public Sensor (string _Nombre)
        {
            Nombre = _Nombre;
            Lectura = Boolean.Parse( ConfigurationManager.OpenExeConfiguration(Assembly.GetEntryAssembly().Location).AppSettings.Settings[key: Nombre].Value);
        }
    }
}
