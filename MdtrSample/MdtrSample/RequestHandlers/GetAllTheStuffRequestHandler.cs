using MdtrSample.Models;
using MdtrSample.Requests;
using MdtrSample.Services;
using MediatR;

namespace MdtrSample.RequestHandlers
{
  public class GetAllTheStuffRequestHandler : IRequestHandler<GetAllTheStuffRequest, List<Stuff>>
  {
    private readonly IStuffService stuffService;

    public GetAllTheStuffRequestHandler(IStuffService stuffService)
    {
      this.stuffService = stuffService;
    }

    public Task<List<Stuff>> Handle(GetAllTheStuffRequest request, CancellationToken ct)
    {
      var result = stuffService.GetAllTheStuff();
      return Task.FromResult(result);
    }

  }
}
