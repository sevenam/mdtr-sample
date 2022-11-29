using MdtrSample.Models;
using MdtrSample.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MdtrSample.Controllers
{
  [ApiController]
  [Route("stuff")]
  public class StuffController : ControllerBase
  {
    private readonly IMediator mediator;

    public StuffController(IMediator mediator)
    {
      this.mediator = mediator;
    }

    [HttpGet("stuff")]
    public IActionResult GetAllTheStuff()
    {
      var allofthestuff = mediator.Send(new GetAllTheStuffRequest()).Result;
      return Ok(allofthestuff);
    }

    [HttpGet("{id}")]
    public IActionResult GetStuffById([FromRoute] Guid id)
    {
      var stuff = mediator.Send(new GetStuffByIdRequest { Id = id}).Result;
      return Ok(stuff);
    }

    [HttpPost]
    public IActionResult CreateStuff([FromBody] Stuff stuff)
    {
      var result = mediator.Send(new AddStuffRequest { Stuff = stuff}).Result;
      return Ok(result);
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteStuff([FromRoute] Guid id)
    {
      var result = mediator.Send(new RemoveStuffRequest { Id = id }).Result;
      return Ok(result);
    }
  }
}
