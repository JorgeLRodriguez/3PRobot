using BLL.Services;
using Domain;

namespace BLL.States
{
    internal class Retroceso : State
    {
        public override void Disparar(Robot Robot)
        {
            new MotorService(Robot.MotorD).Retroceder();
            new MotorService(Robot.MotorI).Retroceder();
            Parlante.Activar();
        }
    }
}
