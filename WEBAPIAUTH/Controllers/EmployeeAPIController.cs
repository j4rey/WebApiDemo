using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
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
            
            UDSSD udssd = new UDSSD();
            List<ssdclass> linq = ssdclass.get();

            await System.Threading.Tasks.Task.Run(() =>
            {
                udssd.SSD = linq.Skip(page * count).Take(count).ToList();

                udssd.totalRows = linq.Count();
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
            return 761;
        }

        [AllowAnonymous]
        [EnableCors(origins: "*", headers: "*", methods: "POST")]
        [Route("Login", Name = "Login")]
        public HttpResponseMessage Login(LoginModel loginmodel)
        {
            //return "login returned";

            if (UserModel.Users().Where(x => x.username == loginmodel.username && x.password == loginmodel.password).Any())
            {
                return Request.CreateResponse(HttpStatusCode.OK, UserModel.Users().Where(x => x.username == loginmodel.username && x.password == loginmodel.password).Single());
                ;
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            //NotFound();
        }
    }
}
