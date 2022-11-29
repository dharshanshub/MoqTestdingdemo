using System;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace CatWebAPI.Repository{
    public interface IRepository<TEntity> where TEntity:class
    {
        Task<TEntity> GetAsync();
        
    }
}