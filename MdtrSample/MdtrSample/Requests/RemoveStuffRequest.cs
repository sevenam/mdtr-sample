using MediatR;

namespace MdtrSample.Requests
{
  public class RemoveStuffRequest : IRequest<bool>
  {
    public Guid Id { get; set; }
  }
}
