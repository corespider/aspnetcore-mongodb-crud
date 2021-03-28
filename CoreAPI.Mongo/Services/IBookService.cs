using CoreAPI.Mongo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAPI.Mongo.Services
{
    public interface IBookService
    {
        Task<List<Books>> GetAllAsync();
        Task<Books> GetByIdAsync(string id);
        Task<Books> CreateAsync(Books book);
        Task UpdateAsync(string id, Books book);
        Task DeleteAsync(string id);
    }
}
