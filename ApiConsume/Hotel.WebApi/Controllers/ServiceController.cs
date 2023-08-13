﻿using Hotel.BusinessLayer.Abstract;
using Hotel.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace Hotel.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceService _serviceService;

        [HttpGet]
        public IActionResult ListService()
        {
            var values = _serviceService.TGetList();
            return Ok();
        }
        [HttpPost]
        public IActionResult AddService(Service service)
        {
            _serviceService.TInsert(service);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteService(int id)
        {
            var values = _serviceService.TGetByID(id);
            _serviceService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateService(Service service)
        {
            _serviceService.TUpdate(service);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetService(int id)
        {
            var values = _serviceService.TGetByID(id);
            return Ok();
        }
    }
}
