﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PTC.Web.ViewModels
{
    public class PersonWithAddress
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public bool IsActiv { get; set; }

        public Address Address { get; set; }
    }
}