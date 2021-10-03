using BLL.Contracts;
using BLL.Services;
using Domain;
using System;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            IRobotService robotService = 
                new RobotService(
                    new Robot(
                        new Sensor("I"),
                        new Sensor("D"),
                        new Motor("I"),
                        new Motor("D"),
                        new Parlante("P")
                        )
                    );
            robotService.Arrancar();
            Console.ReadLine();
            robotService.Apagado();

            BitacoraService.Current.Read(
                DateTime.Now.AddHours(-100), DateTime.Now.AddMinutes(+100)).ForEach(item => Console.WriteLine("Fecha:{0} , valor del Sensor Izquierdo: {1} ; valor del Sensor Derecho: {2}", item.Now, item.SI, item.SD)
                );
        }
    }
}
