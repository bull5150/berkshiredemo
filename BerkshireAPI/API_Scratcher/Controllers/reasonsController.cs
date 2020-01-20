using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Swashbuckle.Swagger.Annotations;

namespace API_Scratcher.Controllers
{
    [RoutePrefix("api/reasons")]
    public class reasonsController : ApiController
    {
        /// <summary>
        /// Returns a list of Reasons to work at Berkshire Hathaway
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("list")]
        public List<Models.reasons_list> getListofReasons()
        {
            List<Models.reasons_list> reasonsList = new List<Models.reasons_list>();
            return new Services.list_builder().buildList(reasonsList);
        }
        /// <summary>
        /// Returns a description based on 1-3 int.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("descriptions")]
        public Models.reasons_description getDescription(int id)
        {
            return new Services.reason_builder().descriptionBuilder(id);
        }
    }
}
