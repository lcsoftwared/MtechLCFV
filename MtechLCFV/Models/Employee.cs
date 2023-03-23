using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MtechLCFV.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Requerido.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Requerido.")]
        public string LastName { get; set; }
        [Key]
        [Required(ErrorMessage = "Requerido.")]
        [MaxLength(13, ErrorMessage = "Solo pueden ser 13 Caracteres")]
        [RegularExpression(@"^([A-ZÑ\x26]{3,4}([0-9]{2})(0[1-9]|1[0-2])(0[1-9]|1[0-9]|2[0-9]|3[0-1]))((-)?([A-Z\d]{3}))?$", ErrorMessage = "Formato Invalido AAAA000000+++")]
        public string Rfc { get; set; }
        [Required(ErrorMessage = "Requerido.")]
        public DateTime BornDate { get; set; }
        [Required(ErrorMessage = "Requerido.")]
        public int EmployeeStatus { get; set; }
        [NotMapped]
        public List<SelectListItem> EmployeeStatusL { set; get; }
    }
}
