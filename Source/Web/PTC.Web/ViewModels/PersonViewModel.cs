using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PTC.Web.ViewModels
{
    public class PersonViewModel
    {
        [Required]
        [StringLength(100, MinimumLength = 10)]
        public string Name { get; set; }

        [Range(18, 100)]
        public int Age { get; set; }

        public bool IsActiv { get; set; }

        public DateTime RegisterOn { get; set; }
    }
}