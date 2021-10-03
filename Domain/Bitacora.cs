using System;

namespace Domain
{
    [Serializable]
    public class Bitacora
    {
        public DateTime Now;
        public bool SI;
        public bool SD;
        public Bitacora(bool _sensorI, bool _sensorD)
        {
            Now = DateTime.Now;
            SI = _sensorI;
            SD = _sensorD;
        }
    }
}