using System;
using System.Collections.Generic;
using System.Text;

namespace News.Models
{
    public class Planet
    {
        public string Name { get; set; }
        public string RotationPeriod { get; set; }
        public string OrbitalPeriod { get; set; }
        public string Diameter { get; set; }
        public string Climate { get; set; }
        public string Gravity { get; set; }
        public string Terrain { get; set; }
        public string SurfaceWater { get; set; }
        public string Population { get; set; }
    }

    public class StarWarsResult
    {
        public string Status { get; set; }
        public int TotalResults { get; set; }
        public List<Planet> Planets { get; set; }
    }
}
