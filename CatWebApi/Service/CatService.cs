using System.Threading.Tasks;
using CatWebAPI.Models;
using CatWebAPI.Repository;

namespace CatWebAPI.Service
{

    public class CatService
    {
        IRepository<Cat> _repository;
        public CatService(IRepository<Cat> repository)
        {
            _repository = repository;
        }
        public async Task<string> GetFact()
        {
             var cat =await _repository.GetAsync();
             return $"fact - {cat.fact} Length is  {cat.length}";
        }
    }
}
