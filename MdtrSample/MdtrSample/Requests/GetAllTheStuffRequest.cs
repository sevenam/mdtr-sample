using MdtrSample.Models;
using MediatR;

namespace MdtrSample.Requests
{
  public class GetAllTheStuffRequest : IRequest<List<Stuff>>
  {
  }
}
