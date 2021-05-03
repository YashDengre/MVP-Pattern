using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DomainLayer.Models.Department
{
    public class DepartmentModel : IDepartmentModel
    {
        public int DepartmentId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Department Name is required")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Department Name must be 5 or 20 characters ")]
        public string DepartmentName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Department DepartmentUrl is required")]
        public string DepartmentUrl { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Department PhoneNumber is required")]
        [MaxLength(11, ErrorMessage = "Not a valid Phone number, length should not be greater than 11")]
        public string PhoneNumber { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Department Email is required")]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Incorrect Email Format")]
        public string Email { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Department CityLocation is required")]
        public string CityLocation { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Department StateLocation is required")]
        public string StateLocation { get; set; }

    }
}
