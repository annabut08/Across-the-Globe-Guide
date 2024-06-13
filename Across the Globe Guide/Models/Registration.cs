using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Across_the_Globe_Guide.Models;
using System.Text.Json;

namespace Across_the_Globe_Guide.Models
{
    public class Registration
    {
        public Registration()
        {
            Users = new List<User>();
        }
        public List<User> Users { get; set; }

        public void SaveData(string path)
        {
            var jsonString = JsonSerializer.Serialize(this);
            File.WriteAllText(path, jsonString);
        }

        public static Registration LoadData(string path)
        {
            var jsonString = File.ReadAllText(path);
            return JsonSerializer.Deserialize<Registration>(jsonString);
        }

    }
           
}
