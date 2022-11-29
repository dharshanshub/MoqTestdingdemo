
using Xunit;
using Moq;
using CatWebAPI.Service;
using CatWebAPI.Repository;
using CatWebAPI.Models;

namespace CatTestProject
{

    public class CatTest
    {

        private readonly CatService _catservice;
        private readonly Mock<IRepository<Cat>> catrepo = new Mock<IRepository<Cat>>();

        public CatTest()
        {
            _catservice = new CatService(catrepo.Object);
        }

        [Fact]
        public async void Test1()
        {
            //arrange
            var cat = new Cat{
                fact="the cat is white",
                length=14
            };
            catrepo.Setup(x=>x.GetAsync()).ReturnsAsync(cat);
            //act
            var fact = await _catservice.GetFact();
            //assert
            Assert.IsType<string>(fact);
            Assert.Equal("fact - the cat is white Length is  14",fact);


        }
    }
}
