using MdtrSample.Models;
using MdtrSample.Requests;
using MdtrSample.Services;
using MediatR;

namespace MdtrSample.RequestHandlers
{
  public class GetStuffByIdRequestHandler : IRequestHandler<GetStuffByIdRequest, Stuff>
  {
    private readonly IStuffService stuffService;

    public GetStuffByIdRequestHandler(IStuffService stuffService)
    {
      this.stuffService = stuffService;
    }

    public Task<Stuff> Handle(GetStuffByIdRequest request, CancellationToken ct)
    {
      var result = stuffService.GetStuffById(request.Id);
      return Task.FromResult(result);
    }

  }
}
