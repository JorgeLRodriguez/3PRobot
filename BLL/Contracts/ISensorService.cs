namespace BLL.Contracts
{
    interface ISensorService
    {
        void Agregar(IObserverSensor sensor);
        void Quitar(IObserverSensor sensor);
    }
}