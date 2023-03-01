using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BlazorCar.Shared
{
    public class Edition
    {
        public int Id { get; set; }

        public string Name { get; set; }

        //avoiding object cycle error
        [JsonIgnore]
        public List<Car> Cars { get; set; }

    }
}
