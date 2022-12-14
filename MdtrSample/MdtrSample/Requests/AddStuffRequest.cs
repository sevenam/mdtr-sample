using MdtrSample.Models;
using MediatR;

namespace MdtrSample.Requests
{
  public class AddStuffRequest : IRequest<bool>
  {
    public Stuff Stuff { get; set; }
  }
}
