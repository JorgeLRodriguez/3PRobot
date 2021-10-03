using BLL.Services;
using Domain;

namespace BLL.States
{
    internal class Avanzar : State
    {
        public override void Disparar(Robot Robot)
        {
            new MotorService(Robot.MotorD).Avanzar();
            new MotorService(Robot.MotorI).Avanzar();
            Parlante.Desactivar();
        }
    }
}
