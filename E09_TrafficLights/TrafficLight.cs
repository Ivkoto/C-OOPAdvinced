using System;

namespace E09_TrafficLights
{
    public class TrafficLight
    {
        public TrafficLight(Lights currentLight)
        {
            this.CurrentLight = currentLight;
        }

        private Lights CurrentLight { get; set; }

        public void ChangeLight()
        {
            var lightCount = Enum.GetNames(typeof(Lights)).Length;
            var nextLight = (int)this.CurrentLight + 1;
            this.CurrentLight = (Lights)(nextLight % lightCount);            
        }

        public override string ToString() => this.CurrentLight.ToString();
    }
}