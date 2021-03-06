﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace ecommerce.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(256, ErrorMessage = "The field {0} can contain maximun {1} and minimum {2} characters")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [Index("User_UserName_Index", IsUnique = true)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(50, ErrorMessage = "The field {0} can contain maximun {1} and minimum {2} characters")]
        [Display(Name = "Nombre")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(50, ErrorMessage = "The field {0} can contain maximun {1} and minimum {2} characters")]
        [Display(Name = "Apellidos")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(20, ErrorMessage = "The field {0} can contain maximun {1} and minimum {2} characters")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(100, ErrorMessage = "The field {0} can contain maximun {1} and minimum {2} characters")]
        public string Address { get; set; }


        [DataType(DataType.ImageUrl)]
        public string Photo { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Range(1, double.MaxValue, ErrorMessage = "You must select a {0}")]
        [Display(Name = "Departamento")]
        public int DepartmentId { get; set; }


        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Range(1, double.MaxValue, ErrorMessage = "You must select a {0}")]
        [Display(Name = "Ciudad")]
        public int CityId { get; set; }

        [NotMapped]
        public HttpPostedFileBase PhotoFile { get; set; }

        [Display(Name = "Compañia")]
        public int CompanyId { get; set; }

        [Display(Name = "Usuario")]
        public string FullName { get { return string.Format("{0} {1}", FirstName, LastName); } }

        public virtual City City { get; set; }

        public virtual Department Department { get; set; }

        public virtual Company Company { get; set; }


    }
}