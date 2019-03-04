using System;
using System.Collections.Generic;

namespace iterating_planets
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>(){"Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune"};
            List<Dictionary<string, string>> probes = new List<Dictionary<string, string>>();
            probes.Add (new Dictionary<string, string>(){ {"Mercury", "Whatever"} });
            probes.Add (new Dictionary<string, string>(){ {"Venus", "Akatsuki"} });
            probes.Add (new Dictionary<string, string>(){ {"Earth", "We Live Here"} });
            probes.Add (new Dictionary<string, string>(){ {"Mars", "Odyssey"} });
            probes.Add (new Dictionary<string, string>(){ {"Mars", "Express"} });
            probes.Add (new Dictionary<string, string>(){ {"Mars", "Reconnaissance Orbiter"} });
            probes.Add (new Dictionary<string, string>(){ {"Jupiter", "Juno"} });
            probes.Add (new Dictionary<string, string>(){ {"Saturn", "Voyager 1"} });
            probes.Add (new Dictionary<string, string>(){ {"Uranus", "Voyager 2"} });
            probes.Add (new Dictionary<string, string>(){ {"Neptune", "Mickey Mouse"} });

            foreach(string planet in planetList) {
                List<string> matchingProbes = new List<string>();
                foreach(Dictionary<string, string> probe in probes){
                   if(probe.ContainsKey(planet)){
                       foreach(KeyValuePair<string, string> kvp in probe){
                           matchingProbes.Add(kvp.Value);
                       }
                   }
                }      
                Console.WriteLine($"{planet}: {String.Join(",", matchingProbes)}"); 
            }
        }
    }
}
