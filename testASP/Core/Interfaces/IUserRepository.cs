using testASP.Core.Entities;

namespace testASP.Core.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetSomething(int id);
    }
}
