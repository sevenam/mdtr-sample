using MdtrSample.Models;

namespace MdtrSample.Services
{
  public interface IStuffService
  {
    List<Stuff> GetAllTheStuff();
    Stuff GetStuffById(Guid id);
    bool AddStuff(Stuff stuff);
    bool RemoveStuff(Guid id);
  }
}
