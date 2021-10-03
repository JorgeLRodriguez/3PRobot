using BLL.Contracts;
using Domain;
using System;
using System.Configuration;
using System.Reflection;
using System.Timers;

namespace BLL.Services
{
    internal class SensorService : ISensorService
    {
        private Sensor Sensor;
        private IObserverSensor Suscriptor;
        private Timer Timer = new Timer();
        public void Quitar(IObserverSensor suscriptor)
        {
            Suscriptor = null;
        }
        public void Agregar(IObserverSensor _suscriptor)
        {
            Suscriptor = _suscriptor;
            Timer.Interval = 2000;
            Timer.Elapsed += Recalculate;
            Timer.Start();
        }
        public SensorService (Sensor _sensor)
        {
            Sensor = _sensor;
        }
        private void Recalculate(object sender, ElapsedEventArgs e)
        {
            bool lectura = Boolean.Parse(ConfigurationManager.OpenExeConfiguration(Assembly.GetEntryAssembly().Location).AppSettings.Settings[key: Sensor.Nombre].Value);
            if (lectura != Sensor.Lectura)
            {
                Sensor.Lectura = lectura;
                Suscriptor.Actualizar();
            }
        }
    }
}