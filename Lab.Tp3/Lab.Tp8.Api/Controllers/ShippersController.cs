using Lab.Tp7.Common.Models;
using Lab.Tp7.Logic;
using System.Net.Http;
using System.Web.Http;

namespace Lab.Tp8.Api.Controllers
{
    public class ShippersController : ApiController
    {
        IShippersLogic shippersLogic = new ShippersLogic();

        [Route("api/shippers")]
        [HttpGet]
        public IHttpActionResult Get()
        {
            try
            {
                var response = shippersLogic.GetAll();
                if (response != null)
                {
                    return Ok(response);
                }
                return StatusCode(System.Net.HttpStatusCode.BadRequest);
            }
            catch (System.Exception)
            {
                return StatusCode(System.Net.HttpStatusCode.Unauthorized);
            }
        }

        [Route("api/shippers/{id}")]
        [HttpGet]
        public IHttpActionResult GetById(int id)
        {
            try
            {
                if (shippersLogic.Get(id) != null)
                {
                    var response = shippersLogic.Get(id);
                    return Ok(response);
                }
                return StatusCode(System.Net.HttpStatusCode.BadRequest);
            }
            catch (System.Exception) 
            {
                return StatusCode(System.Net.HttpStatusCode.Unauthorized);
            }
        }

        [Route("api/shippers/add")]
        [HttpPost]
        public IHttpActionResult Insert(ShippersModel shipperModel)
        {
            try
            {
                if (shipperModel != null)
                {
                    shippersLogic.Add(shipperModel);
                    return Ok("Exito");
                }
                return StatusCode(System.Net.HttpStatusCode.BadRequest);
            }
            catch (System.Exception)
            {
                return StatusCode(System.Net.HttpStatusCode.Unauthorized);
            }
        }

        [Route("api/shippers/update/{id}")]
        [HttpPut]
        public IHttpActionResult Update(int id, ShippersModel shipperModel)
        {
            try
            {
                if ((shippersLogic.Get(id) != null) && shipperModel != null)
                {
                    shippersLogic.Update(id,shipperModel);
                    return Ok("Exito");
                }
                return StatusCode(System.Net.HttpStatusCode.BadRequest);
            }
            catch (System.Exception)
            {
                return StatusCode(System.Net.HttpStatusCode.Unauthorized);

            }
        }

        [Route("api/shippers/delete/{id}")]
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            try
            {
                if (shippersLogic.Get(id) != null)
                {
                shippersLogic.Delete(id);
                return Ok("Exito");
                }
                return StatusCode(System.Net.HttpStatusCode.BadRequest);
            }
            catch (System.Exception)
            {
                return StatusCode(System.Net.HttpStatusCode.Unauthorized);
            }
        }
    }
}