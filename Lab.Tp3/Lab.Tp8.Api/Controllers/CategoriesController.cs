using Lab.Tp7.Logic;
using System;
using System.Net.Http;
using System.Web.Http;

namespace Lab.Tp8.Api.Controllers
{
    public class CategoriesController : ApiController
    {
        ICategoriesLogic categoriesLogic = new CategoriesLogic();   
        
        [Route("api/categories")]
        [HttpGet]
        public IHttpActionResult Get()
        {
            try
            {
                var response = categoriesLogic.GetAll();
                if(response == null)
                {
                    return StatusCode(System.Net.HttpStatusCode.BadRequest);
                }
                return Ok(response);
            }
            catch (Exception)
            {
                return StatusCode(System.Net.HttpStatusCode.Unauthorized);
            }
        }
    }
}