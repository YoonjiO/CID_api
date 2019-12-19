using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Cors;
using System.IO;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CID_api
{
    [Route("api/values")]
    public class CIDConnectController : Controller
    {
        [DllImport("SKB_OpenAPI_IMS.dll")]
        public static extern int IMS_Init(string strAppKey);

        [DllImport("SKB_OpenAPI_IMS.dll")]
        public static extern int IMS_GetVersion();

        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            //var nResult = IMS_GetVersion();
            //System.Diagnostics.Debug.WriteLine(nResult);

            return new string[] { "haha", "hoho" };
        }
    }
}
