using MdtrSample.Models;
using MediatR;

namespace MdtrSample.Requests
{
  public class GetStuffByIdRequest : IRequest<Stuff>
  {
    public Guid Id { get; set; }
  }
}
