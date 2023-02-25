using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCar.Shared
{
    //Specifying the Categories that we will use for our cars! 
    public class Category
    {
        //for information regarding the use of public - please refer to Car.cs        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
    }
}
