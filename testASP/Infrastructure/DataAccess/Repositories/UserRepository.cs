using Microsoft.AspNetCore.Mvc.Infrastructure;
using testASP.Core.Entities;
using testASP.Core.Interfaces;
using testASP.Infrastructure.Entities;

namespace testASP.Infrastructure.DataAccess.Repositories
{
    public class UserRepository : IUserRepository
    {
        //private readonly _dbFactory;
        public UserRepository(/*DbContextFactory contextFactory*/)
        {
            //_dbFactory; = dbFactory;
        }
        public Task<User> GetSomething(int id)
        {//тут будем с помощь фабрики открывать подключение и запрашивать данные
            //using var context = _dbFactory.CreateDbContext();
            //UserDB userDB = await context.users.FirstOrDefaultAsync(u => u.id == id);
            //дальше преобразование в доменную модель, которая будет находиться в папке сущностей из Core, а в Applications уже мапер преобразует его в нужный вариант DTO и отдаст контроллеру.
            //User user = Mapper.ToDomenModel(userDb)
            //return User;
            throw new NotImplementedException();
        }
    }
}
