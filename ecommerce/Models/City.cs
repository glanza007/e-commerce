﻿using System.ComponentModel.DataAnnotations;

namespace ecommerce.Models
{
    public class City
    {
        [Key]
        public int CityId { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(50, ErrorMessage =
            "The field {0} can contain maximun {1} and minimum {2} characters",
            MinimumLength = 3)]
        public string Name { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }

    }
}