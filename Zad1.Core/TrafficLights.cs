namespace Zad1.Core
{
    public class TrafficLights
    {
        public bool Red { get; set; }
        public bool Yellow { get; set; }
        public bool Green { get; set; }

        private const bool On = true;
        private const bool Off = false;

        public void SetStop()
        {
            LightColors(On, Off, Off);
        }

        public void SetPrepareToStart()
        {
            LightColors(On, On, Off);
        }

        public void SetStart()
        {
            LightColors(Off, Off, On);
        }

        public void SetPrepareToStop()
        {
            LightColors(Off, On, Off);
        }

        private void LightColors(bool red, bool yellow, bool green)
        {
            Red = red;
            Yellow = yellow;
            Green = green;
        }
    }
}
