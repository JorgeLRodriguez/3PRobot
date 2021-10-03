using BLL.Contracts;
using BLL.States;
using Domain;

namespace BLL.Services
{
    public class RobotService : IRobotService, IObserverSensor
    {
        private State state;
        private readonly Robot Robot;
        private readonly ISensorService SensorServiceA;
        private readonly ISensorService SensorServiceB;
        private readonly IBitacoraService Bitacora;
        public RobotService (Robot _robot)
        {
            Robot = _robot;
            SensorServiceA = new SensorService(Robot.SensorA);
            SensorServiceB = new SensorService(Robot.SensorB);
            Bitacora = BitacoraService.Current;
        }
        public void Actualizar()
        {
            if (Robot.SensorA.Lectura && Robot.SensorB.Lectura) state = new Avanzar();
            if (Robot.SensorA.Lectura && !Robot.SensorB.Lectura) state = new Izquierda();
            if (!Robot.SensorA.Lectura && Robot.SensorB.Lectura) state = new Derecha();
            if (!Robot.SensorA.Lectura && !Robot.SensorB.Lectura) state = new Retroceso();
            state.Disparar(Robot);
            Bitacora.Create(new Bitacora(Robot.SensorA.Lectura, Robot.SensorB.Lectura));
        }
        public void Arrancar()
        {
            SensorServiceA.Agregar(this);
            SensorServiceB.Agregar(this);
        }
        public void Apagado()
        {
            SensorServiceA.Quitar(this);
            SensorServiceB.Quitar(this);
        }
    }
}