using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PTC.Web.ViewModels
{
    public class Person
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Job { get; set; }

        public DateTime RgisteredOn { get; set; }

        public int Age { get; set; }
    }
}