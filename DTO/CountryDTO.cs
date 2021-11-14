using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Hotel_API.DTO;

namespace Hotel_API.Dto
{
    public class CountryDTO : CreateCountryDTO
    {
        public int Id { get; set; }
        public virtual IList<HotelDTO> Hotels { get; set; }
    }

    public class CreateCountryDTO

    {
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Country Name Too Long")]
        public string Name { get; set; }

        [Required]
        [StringLength(maximumLength: 2, ErrorMessage = "Short Country Name Too Long")]
        public string ShortName { get; set; }
    }
}