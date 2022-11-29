﻿using MdtrSample.Models;
using MdtrSample.Services;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MdtrSample.Controllers
{
  [ApiController]
  [Route("stuff")]
  public class StuffController : ControllerBase
  {
    private readonly IStuffService stuffService;
    private readonly IMediator mediator;

    public StuffController(IStuffService stuffService, IMediator mediator)
    {
      this.stuffService = stuffService;
      this.mediator = mediator;
    }

    [HttpGet("stuff")]
    public IActionResult GetAllTheStuff()
    {
      var allofthestuff = stuffService.GetAllTheStuff();
      return Ok(allofthestuff);
    }

    [HttpGet("{id}")]
    public IActionResult GetStuffById([FromRoute] Guid id)
    {
      var stuff = stuffService.GetStuffById(id);
      return Ok(stuff);
    }

    [HttpPost]
    public IActionResult CreateStuff([FromBody] Stuff stuff)
    {
      var result = stuffService.AddStuff(stuff);
      return Ok(result);
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteStuff([FromRoute] Guid id)
    {
      var result = stuffService.RemoveStuff(id);
      return Ok(result);
    }
  }
}
