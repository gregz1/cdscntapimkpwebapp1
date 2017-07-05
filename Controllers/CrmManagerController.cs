using Microsoft.AspNetCore.Mvc;
using cdscntapimkpwebapp1.Models;
using cdscntapimkpwebapp1.Models.CrmManager;
using Microsoft.AspNetCore.Http;
using cdscntapimkpwebapp1.Enumeration;
using System;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace cdscntapimkpwebapp1.Controllers
{
    public class CrmManagerController : Controller
    {
        // GET: /<controller>/
        const string SessionLogin = "_Login";
        const string SessionToken = "_Token";
        const string SessionEnvironment = "_Environment";


        //Autentication _Autentication;
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome()
        {
            //ViewData["Message"] = "Hello " + name;
            //ViewData["NumTimes"] = numTimes;

            return View();
        }

        public void GetSessionData(ref Request MyRequest)
        {
            /*if (HttpContext.Session.GetString(SessionToken) != null)
            {
                MyRequest._Login = HttpContext.Session.GetString(SessionLogin);
                MyRequest._Token = HttpContext.Session.GetString(SessionToken);
                MyRequest._EnvironmentSelected = (EnvironmentEnum)Enum.Parse(typeof(EnvironmentEnum), HttpContext.Session.GetString(SessionEnvironment));
            }*/

        }
        public void SetSessionData(Request MyRequest)
        {
            /*if (MyRequest != null)
            {
                HttpContext.Session.SetString(SessionLogin, MyRequest._Login);
                HttpContext.Session.SetString(SessionToken, MyRequest._Autentication._Token);
                HttpContext.Session.SetString(SessionEnvironment, MyRequest._EnvironmentSelected.ToString());
            }*/
        }
        
        public ActionResult GetOrderClaimListRequest()
        {
            Request MyRequest = new GetOrderClaimListRequest();
            GetSessionData(ref MyRequest);
            return View(MyRequest);
        }
        [HttpPost]
        public ActionResult GetOrderClaimListMessage(GetOrderClaimListRequest MyRequest)
        {
            MyRequest.GetHeaderMessage();
            SetSessionData(MyRequest);
            return View(new GetOrderClaimListMessage(MyRequest));
        }
        public ActionResult GetOfferQuestionListRequest()
        {
            Request MyRequest = new GetOrderClaimListRequest();
            GetSessionData(ref MyRequest);
            return View(MyRequest);
        }
        [HttpPost]
        public ActionResult GetOfferQuestionListMessage(GetOfferQuestionListRequest MyRequest)
        {
            MyRequest.GetHeaderMessage();
            SetSessionData(MyRequest);
            return View(new GetOfferQuestionListMessage(MyRequest));
        }
        public ActionResult CloseDiscussionListRequest()
        {
            Request MyRequest = new CloseDiscussionListRequest();
            GetSessionData(ref MyRequest);
            return View(MyRequest);
        }
        [HttpPost]
        public ActionResult CloseDiscussionListMessage(CloseDiscussionListRequest MyRequest)
        {
            MyRequest.GetHeaderMessage();
            SetSessionData(MyRequest);
            return View(new CloseDiscussionListMessage(MyRequest));
        }

        public ActionResult GetDiscussionMailListRequest()
        {
            Request MyRequest = new GetDiscussionsMailRequest();
            GetSessionData(ref MyRequest);
            return View(MyRequest);
        }
        [HttpPost]
        public ActionResult GetDiscussionMailListMessage(GetDiscussionsMailRequest MyRequest)
        {
            MyRequest.GetHeaderMessage();
            SetSessionData(MyRequest);
            return View(new GetDiscussionMailMessage(MyRequest));
        }
    }
}
