namespace Domain
{
    public class Robot
    {
        public Sensor SensorA { get; set; }
        public Sensor SensorB { get; set; }
        public Motor MotorI { get; set; }
        public Motor MotorD { get; set; }
        public Parlante Parlante { get; set; }
        public Robot(){}
        public Robot(Sensor _sensorA, Sensor _sensorB, Motor _motorI, Motor _motorD, Parlante _parlante)
        {
            this.SensorA = _sensorA;
            this.SensorB = _sensorB;
            this.MotorI = _motorI;
            this.MotorD = _motorD;
            this.Parlante = _parlante;
        }
    }
}
