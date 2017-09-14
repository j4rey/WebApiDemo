using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using WEBAPIAUTH.Models;

namespace WEBAPIAUTH.Controllers
{
    [Authorize]
    [RoutePrefix("api/Employee")]
    public class EmployeeAPIController : ApiController
    {
        [AllowAnonymous]
        [EnableCors(origins: "*", headers: "*", methods: "GET")]
        [Route("GetList", Name = "GetList")]
        //[Filters.CustomAuthorization]
        public async System.Threading.Tasks.Task<UDSSD> Get(int count=10, int page=0)
        {
            //this.ControllerContext.RouteData.Values["action"].ToString();
            //this.ControllerContext.RouteData.Values["controller"].ToString();
            UCM85_dbEntities entities = new UCM85_dbEntities();
            //var ssd = entities.SOCIALSHARINGDETAILS.Take(5);
            UDSSD udssd = new UDSSD();
            //udssd.SSD = (entities.SOCIALSHARINGDETAILS.OrderBy(x=>x.DATE_ENTERED).Skip(page * count).Take(count))
            //    .Select((v, i) => new ssdclass (){
            //        indexCount = i,
            //        ID = v.ID,
            //        POST_NAME = v.POST_NAME,
            //        POST_CONTENT  = v.POST_CONTENT,
            //        POST_TYPE = v.POST_TYPE,
            //        DATE_ENTERED = v.DATE_ENTERED
            //    })
            //    .ToList();

            await System.Threading.Tasks.Task.Run(() =>
            {
                List<SOCIALSHARINGDETAILS> lst =  entities.SOCIALSHARINGDETAILS.OrderBy(x => x.DATE_ENTERED).Select(x => x).ToList();

                var linq = lst.Select((v, i) => new ssdclass()
                {
                    indexCount = i,
                    ID = v.ID,
                    POST_NAME = v.POST_NAME,
                    POST_CONTENT = v.POST_CONTENT,
                    POST_TYPE = v.POST_TYPE,
                    DATE_ENTERED = v.DATE_ENTERED
                }).ToList();

            
            udssd.SSD = linq.Skip(page * count).Take(count).ToList();

            udssd.totalRows = entities.SOCIALSHARINGDETAILS.Count();
            udssd.currentPage = page;
            }
            );
            return udssd;
            
            //return new EmployeeDatabase();
        }

        [AllowAnonymous]
        [EnableCors(origins: "*", headers: "*", methods: "GET")]
        [Route("GetCount", Name = "GetCount")]
        public int GetCount()
        {
            UCM85_dbEntities entities = new UCM85_dbEntities();
            return entities.SOCIALSHARINGDETAILS.Count();
        }
    }
}
