using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Hotel_API.Dto;
using Hotel_API.Model;

namespace Hotel_API.DTO
{
    public class HotelDTO : CreateHotelDTO
    {
        public int Id { get; set; }

        public CountryDTO Country { get; set; }
    }

    public class CreateHotelDTO
    {
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Hotel Name is Too Long")]
        public string Name { get; set; }

        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Address is Too Long")]
        public string Address { get; set; }

        [Required]
        [Range(1, 5)]
        public double Rating { get; set; }

        [Required]
        public int CountryId { get; set; }
    }
}