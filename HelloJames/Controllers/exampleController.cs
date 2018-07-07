using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Security;

namespace HelloJames.Controllers
{
	[RoutePrefix("api/example")]
	public class ExampleController : ApiController
	{
		[HttpGet, Route("exampleget")]
		public string Get()
		{
			return "This data was loaded on page load";
		}

		[HttpPost, Route("examplepost")]
		public List<string> Post(ExampleObject obj)
		{
			return obj.foo;
		}

		public class ExampleObject {
			public List<string> foo { get; set; }
			public bool bar { get; set; }
		}
	}
}