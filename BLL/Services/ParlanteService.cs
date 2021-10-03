using BLL.Contracts;
using System;

namespace BLL.Services
{
    internal class ParlanteService : IParlanteService
    {
        public void Activar()
        {
            Console.WriteLine("Parlante encendido.");
        }

        public void Desactivar()
        {
            Console.WriteLine("Parlante desactivado.");
        }
    }
}