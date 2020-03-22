using JWTWebAPIAuth.JWTAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace JWTWebAPIAuth.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        [JwtAuthentication]
        public string GetAPIData()
        {
            return "Welcome to CoreProgramm";
        }
    }
}
