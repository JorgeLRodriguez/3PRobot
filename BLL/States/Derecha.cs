using BLL.Services;
using Domain;

namespace BLL.States
{
    internal class Derecha : State
    {
        public override void Disparar(Robot Robot)
        {
            new MotorService(Robot.MotorI).Avanzar();
            new MotorService(Robot.MotorD).Retroceder();
            Parlante.Desactivar();
        }
    }
}
