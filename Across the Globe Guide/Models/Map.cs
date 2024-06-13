using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Across_the_Globe_Guide.Models;
using System.Text.Json;

namespace Across_the_Globe_Guide.Models
{
    public class Map
    {
        public Map()
        {
            Coordinates = new List<Coordinate>();
        }

        public List<Coordinate> Coordinates { get; set; }

        public void SaveData(string path)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (var coord in Coordinates)
                {
                    writer.WriteLine($"{coord.PlaceName}: {coord.Latitude}, {coord.Longitude}");
                }
            }
        }

      
    }
}