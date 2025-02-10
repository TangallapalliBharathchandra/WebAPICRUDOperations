using FakeItEasy;

using WebAPICRUDOperations.Controllers;

namespace WebAPICRUDOperations.Test.Controllers
{
    public class OurHeroControllerTest 
    {
        private readonly IOurHeroService _heroService;

        public OurHeroControllerTest()
        {
            _heroService = A.Fake<IOurHeroService>();
        }
    }
}
