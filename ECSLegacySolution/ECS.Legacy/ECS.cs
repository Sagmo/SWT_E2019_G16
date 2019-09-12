namespace ECS.Legacy
{
    public class ECS
    {
        private int _threshold;
        //private readonly TempSensor _tempSensor;
        private readonly Interface_TempSensor _tempSensor;

        private readonly Interface_Heater _heater;
        //private readonly Heater _heater;

        public ECS(int thr, Interface_TempSensor iTempSensor, Interface_Heater iHeater)
        {
            SetThreshold(thr);
            _tempSensor = ITempSensor;
            _heater = IHeater;
        }

        public void Regulate()
        {
            var t = _tempSensor.GetTemp();
            if (t < _threshold)
                _heater.TurnOn();
            else
                _heater.TurnOff();

        }

        public void SetThreshold(int thr)
        {
            _threshold = thr;
        }

        public int GetThreshold()
        {
            return _threshold;
        }

        public int GetCurTemp()
        {
            return _tempSensor.GetTemp();
        }

        public bool RunSelfTest()
        {
            return _tempSensor.RunSelfTest() && _heater.RunSelfTest();
        }
    }
}
