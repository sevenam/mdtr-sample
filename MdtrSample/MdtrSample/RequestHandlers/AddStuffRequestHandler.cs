using MdtrSample.Requests;
using MdtrSample.Services;
using MediatR;

namespace MdtrSample.RequestHandlers
{
  public class AddStuffRequestHandler : IRequestHandler<AddStuffRequest, bool>
  {
    private readonly IStuffService stuffService;

    public AddStuffRequestHandler(IStuffService stuffService)
    {
      this.stuffService = stuffService;
    }

    public Task<bool> Handle(AddStuffRequest request, CancellationToken ct)
    {
      var result = stuffService.AddStuff(request.Stuff);
      return Task.FromResult(result);
    }
  }
}
