using DatingApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApi.Data
{
    public interface IDatingRepository
    {
        void Add<T>(T entity) where T : class;

        void Delete<T>(T entity) where T : class;

        Task<bool> SavedAll();

        Task<IEnumerable<User>> GetUsers();

        Task<User> GetUser(int id);
    }
}
