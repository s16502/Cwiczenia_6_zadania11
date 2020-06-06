using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Cwiczenia_6_zadania11.DTOs;
using Cwiczenia_6_zadania11.Services;

namespace Cwiczenia_6_zadania11.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly IDbService _service;

        public DoctorsController(IDbService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetDoctors()
        {
            return Ok(_service.GetDoctors());
        }

        [HttpPost]
        public IActionResult AddDoctor(AddDoctorRequest request)
        {
            return Ok(_service.AddDoctor(request));
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteDoctor(int id)
        {
            return Ok(_service.DeleteDoctor(id));
        }

        [HttpPut]
        public IActionResult UpdateDoctor(UpdateDoctorRequest request)
        {
            return Ok(_service.UpdateDoctor(request));
        }
    }
}