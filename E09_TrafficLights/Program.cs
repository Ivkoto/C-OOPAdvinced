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
            try
            {
                var trafficLightsInput = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var trafficLights = new List<TrafficLight>();

                foreach (var light in trafficLightsInput)
                {
                    var curLight = (Lights)Enum.Parse(typeof(Lights), light);
                    var trafficLight = new TrafficLight(curLight);
                    trafficLights.Add(trafficLight);
                }

                var timesToChangeLight = int.Parse(Console.ReadLine());

                for (int i = 0; i < timesToChangeLight; i++)
                {
                    foreach (var trafficLight in trafficLights)
                    {
                        trafficLight.ChangeLight();
                    }
                    PrintCurrentState(trafficLights);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }            
        }

        private static void PrintCurrentState(List<TrafficLight> trafficLights)
        {
            Console.WriteLine(string.Join(" ", trafficLights));
        }
    }
}