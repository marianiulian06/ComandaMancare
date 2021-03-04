using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Umbraco.Web.WebApi;

namespace comandamancare.Controllers
{
    public class MyApiController : UmbracoApiController
    {     // umbraco/api/myapi/post
        public bool Post()
        {
            return true;
        }
        // umbraco/api/myapi/get
        [HttpGet]
        public string Get()
        {
            return "api is working";
        }

        [Route("api/getname")]
        public string Name()
        {
            return GetNames();
        }

        private string GetNames()
        {
            var names = new[]
            {
                "test",
                "test1",
                "test2",
                "test3",
            };
            return names[new Random().Next(0, names.Length)];
        }
    }
}