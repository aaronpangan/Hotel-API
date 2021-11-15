using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_API.Model
{
    public class CountryModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string ShortName { get; set; }

        public virtual IList<HotelModel> Hotels { get; set; }
    }
}