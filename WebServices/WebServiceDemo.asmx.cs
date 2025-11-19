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

        [WebMethod(EnableSession = true)]
        public int Add(int firstNumber, int secondNumber)
        {
            List<string> calculations;

            if(Session["CALCULATIONS"] == null)
            {
                calculations = new List<string>();
            }
            else
            {
                calculations = (List<string>)Session["CALCULATIONS"];
            }

            string strRecentCalculations = 
                " " + firstNumber.ToString() + " + " + secondNumber.ToString() + " = " 
                + (firstNumber + secondNumber).ToString() + " ";

            calculations.Add(strRecentCalculations);
            Session["CALCULATIONS"] = calculations;

            return firstNumber + secondNumber;
        }

        [WebMethod(EnableSession = true)]
        // This method return all the recent calculations which user performed
        public List<string> GetCalculations()
        {
            if(Session["CALCULATIONS"] == null)
            {
                List<string> calculations = new List<string>();
                calculations.Add("You have not performed any calculations");
                return calculations;
            }
            else
            {
                return (List<string>)Session["CALCULATIONS"];
            }
        }




    }
}
