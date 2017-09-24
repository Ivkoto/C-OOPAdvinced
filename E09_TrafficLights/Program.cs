using System;
using System.Collections.Generic;
using System.Linq;

namespace E09_TrafficLights
{
    public class Program
    {
        public static void Main()
        {
            TurnTheTrafficLightsOn();            
        }

        private static void TurnTheTrafficLightsOn()
        {
            var trafficLightsInput = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var trafficLights = new List<Lights>(trafficLightsInput.Select(l => (Lights)Enum.Parse(typeof(Lights), l)));
            var timesToChangeLight = int.Parse(Console.ReadLine());

            for (int i = 0; i < timesToChangeLight; i++)
            {
                for (int l = 0; l < trafficLights.Count; l++)
                {
                    var light = trafficLights[l];
                    var stateMachine = new LightStateMachine(light);
                    stateMachine.ChangeLight();
                    trafficLights[l] = stateMachine.CurrentLight;
                }
                PrintCurrentState(trafficLights);
            }
        }

        private static void PrintCurrentState(List<Lights> trafficLights)
        {
            Console.WriteLine(string.Join(" ", trafficLights));
        }
    }
}