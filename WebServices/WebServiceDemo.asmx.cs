using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServices
{
    /// <summary>
    /// Summary description for WebServiceDemo
    /// </summary>
    [WebService(Namespace = "http://demotech.com/webservices")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceDemo : System.Web.Services.WebService
    {

        [WebMethod]
        public int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}
