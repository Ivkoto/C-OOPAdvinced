namespace E09_TrafficLights
{
    public class LightStateMachine
    {
        public LightStateMachine(Lights currentLight)
        {
            this.CurrentLight = currentLight;
        }

        public Lights CurrentLight { get; private set; }

        public void ChangeLight()
        {
            if (this.CurrentLight == Lights.Red)
            {
                this.CurrentLight = Lights.Green;
            }
            else if (this.CurrentLight == Lights.Green)
            {
                this.CurrentLight = Lights.Yellow;
            }
            else if (this.CurrentLight == Lights.Yellow)
            {
                this.CurrentLight = Lights.Red;
            }
        }
    }
}