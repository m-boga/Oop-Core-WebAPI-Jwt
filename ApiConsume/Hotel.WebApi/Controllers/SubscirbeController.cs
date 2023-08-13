﻿using Hotel.BusinessLayer.Abstract;
using Hotel.DataAccesLayer.Abstract;
using Hotel.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscirbeController : ControllerBase
    {
        private readonly ISubscribeService _subscribeService;

        public SubscirbeController(ISubscribeService subscribeService)
        {
            _subscribeService = subscribeService;
        }

        [HttpGet]
        public IActionResult ListSubscribe()
        {
            var values = _subscribeService.TGetList();
            return Ok();
        }
        [HttpPost]
        public IActionResult AddSubscribe(Subscribe subscribe)
        {
            _subscribeService.TInsert(subscribe);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteSubscribe(int id)
        {
            var values = _subscribeService.TGetByID(id);
            _subscribeService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateSubscribe(Subscribe subscribe)
        {
            _subscribeService.TUpdate(subscribe);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetSubscribe(int id)
        {
            var values = _subscribeService.TGetByID(id);
            return Ok();
        }
    }
}

