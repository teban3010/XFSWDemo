using System;
using System.Collections.Generic;

namespace XFSWDemo.Model
{
    public class Planet
    {
        public string Name { get; set; }
        public string Rotation_period { get; set; }
        public string Orbital_period { get; set; }
        public string Diameter { get; set; }
        public string Climate { get; set; }
        public string Gravity { get; set; }
        public string Terrain { get; set; }
        public string Surface_water { get; set; }
        public string Population { get; set; }
        public List<object> Residents { get; set; }
        public List<string> Films { get; set; }
        public DateTime Created { get; set; }
        public DateTime Edited { get; set; }
        public string Url { get; set; }
    }
}
