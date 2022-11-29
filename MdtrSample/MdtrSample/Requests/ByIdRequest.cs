using MediatR;

namespace MdtrSample.Requests
{
  public class ByIdRequest : IRequest<Guid>
  {
    public Guid Id { get; set; }
  }
}
