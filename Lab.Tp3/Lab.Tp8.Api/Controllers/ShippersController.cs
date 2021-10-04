using Lab.Tp7.Common.Models;
using Lab.Tp7.Logic;
using System.Collections.Generic;
using System.Web.Http;

namespace Lab.Tp8.Api.Controllers
{
    public class ShippersController : ApiController
    {
        IShippersLogic shippersLogic = new ShippersLogic();

        [Route("shippers")]
        [HttpGet]
        public IHttpActionResult Get()
        {
            var response = shippersLogic.GetAll();
            return Ok(response);
        }

        [Route("shippers/add")]
        [HttpPost]
        public IHttpActionResult Insert(ShippersModel shipperModel)
        {
            shippersLogic.Add(shipperModel);
            return Ok("Exito");
        }

        [Route("shippers/update")]
        [HttpPut]
        public IHttpActionResult Update(ShippersModel shipperModel)
        {
            shippersLogic.Update(shipperModel);
            return Ok("Exito");
        }

        [Route("shippers/delete")]
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            shippersLogic.Delete(id);
            return Ok("Exito");
        }



    }
}