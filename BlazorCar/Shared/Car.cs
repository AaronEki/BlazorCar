using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCar.Shared
{
    //defining the class Car and the different "details" it will use
    public class Car
    {
        //as an example we are creating a public integer - this will hold the ID of the car
        //we use public here to make sure it can be accessed from other files - an example of this is in 
        //carList.razor "<a href="/car/@car.Id">" -> this is only possible because these are public!
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; } = "https://via.placeholder.com";
        public string Mileage { get; set; }
        public string Engine { get; set; }
        public string Gearbox { get; set; }
        public string Bodystyle { get; set; }
        public string Colour { get; set; }
        public string Doors { get; set; }        
        
        public bool IsPublic { get; set; }
        public bool IsDeleted { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public List<CarVariant> Variants { get; set; } = new List<CarVariant>();
        //DateTime? makes the value nullable
        public DateTime? DateCreated { get; set; } = DateTime.Now;
        public DateTime? DateUpdated { get; set; }

    }
}
