using MdtrSample.Models;
using MdtrSample.Requests;
using MdtrSample.Services;
using MediatR;

namespace MdtrSample.RequestHandlers
{
  public class DeleteStuffRequestHandler : IRequestHandler<RemoveStuffRequest, bool>
  {
    private readonly IStuffService stuffService;

    public DeleteStuffRequestHandler(IStuffService stuffService)
    {
      this.stuffService = stuffService;
    }

    public Task<bool> Handle(RemoveStuffRequest request, CancellationToken ct)
    {
      var result = stuffService.RemoveStuff(request.Id);
      return Task.FromResult(result);
    }

  }
}
