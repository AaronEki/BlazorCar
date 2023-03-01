using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BlazorCar.Shared
{
    public class CarVariant
    {
        //avoiding object cycle error
        [JsonIgnore]
        public Car Car { get; set; }
        public int CarId { get; set; }
        public Edition Edition { get; set; }  
        //used for creating a composite ID
        public int EditionId { get; set; }

        //Specifying the type of decimal we will be using with the sql server - if we do not specify it could default to 
        //type that we do not want to use! Best to specify that we want this many characters before/after the .
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal OriginalPrice { get; set; }
    }
}
