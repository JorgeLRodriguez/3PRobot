using BLL.Contracts;
using Domain;
using System;

namespace BLL.Services
{
    public class MotorService : IMotorService
    {
        public Motor Motor { get; set; }
        public MotorService(Motor _motor)
        {
            Motor = _motor;
        }
        public void Avanzar()
        {
            Console.WriteLine("Motor {0} avanzando.", Motor.Nombre);
        }

        public void Detener()
        {
            Console.WriteLine("Motor {0} detenido.", Motor.Nombre);
        }

        public void Retroceder()
        {
            Console.WriteLine("Motor {0} retrocediendo.", Motor.Nombre);
        }
    }
}
