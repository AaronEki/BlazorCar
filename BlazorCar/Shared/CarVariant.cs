using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BlazorCar.Shared
{
    internal class CarVariant
    {
        //avoiding object cycle error
        [JsonIgnore]
        public Car Car { get; set; }
        public int CarId { get; set; }
        public Edition Edition { get; set; }  
        //used for creating a composite ID
        public int EditionId { get; set; }
    }
}
