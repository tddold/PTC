using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using PTC.Web.ViewModels;

namespace PTC.Web.Controllers
{
    public class AutoMapperController : Controller
    {
        private readonly IMapper mapper;

        public AutoMapperController(IMapper mapper)
        {
            this.mapper = mapper;
        }

        private List<Person> data = new List<Person>
        {
            new Person
            {
                Name="Pesho",
                Age=22,
                Id=1
            },
            new Person
            {
                Name="Gosho",
                Age=24,
                Id=2
            }
        };

        public ActionResult Index()
        {
            var person =
                this.data
                .Where(p => p.Id == 1)
                .Single();

            var test = this.mapper.Map<Person, PersonViewModel>(person);

            return View(test);
        }
    }
}