using System;
using System.Collections.Generic;

namespace XFSWDemo.Model
{
    public class StarShip
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public string Cost_in_credits { get; set; }
        public string Length { get; set; }
        public string Max_atmosphering_speed { get; set; }
        public string Crew { get; set; }
        public string Passengers { get; set; }
        public string Cargo_capacity { get; set; }
        public string Consumables { get; set; }
        public string Hyperdrive_rating { get; set; }
        public string MGLT { get; set; }
        public string Starship_class { get; set; }
        public List<object> Pilots { get; set; }
        public List<string> Films { get; set; }
        public DateTime Created { get; set; }
        public DateTime Edited { get; set; }
        public string Url { get; set; }
    }
}
