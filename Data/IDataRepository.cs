using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.Language.Intermediate;
using WaifuDatingApp.API.Models;

namespace WaifuDatingApp.API.Data
{
    public interface IDataRepository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveAll();
        Task<IEnumerable<User>> GetUsers();
        Task<User> GetUser(int id);
    }
}