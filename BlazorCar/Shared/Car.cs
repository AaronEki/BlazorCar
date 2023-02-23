using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCar.Shared
{
    public class Car
    {
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
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal OriginalPrice { get; set; }
        public bool IsPublic { get; set; }
        public bool IsDeleted { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime DateUpdated { get; set; }

    }
}
