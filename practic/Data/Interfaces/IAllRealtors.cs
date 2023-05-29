using practic.Data.Models;

namespace practic.Data.Interfaces
{
    public interface IAllRealtors
    {
        IEnumerable<Realtor> Realtors { get; }
        Realtor getObjRealtor(int id);
    }
}
