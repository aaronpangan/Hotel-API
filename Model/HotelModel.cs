using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_API.Model
{
    public class HotelModel
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }
        public double Rating { get; set; }

        [ForeignKey(nameof(CountryModel))]
        public int CountryId { get; set; }

        public CountryModel Country { get; set; } //You also need to include the model in addition to the Foreign Key Id
    }
}