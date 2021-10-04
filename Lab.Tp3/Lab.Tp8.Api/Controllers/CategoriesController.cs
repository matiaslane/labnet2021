using Lab.Tp7.Logic;
using System.Web.Http;

namespace Lab.Tp8.Api.Controllers
{
    public class CategoriesController : ApiController
    {
        ICategoriesLogic categoriesLogic = new CategoriesLogic();   
        
        [Route("categories")]
        [HttpGet]
        public IHttpActionResult Get()
        {
            var response = categoriesLogic.GetAll();

            return Ok(response);
        }
    }
}