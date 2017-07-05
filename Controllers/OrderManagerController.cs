using Microsoft.AspNetCore.Mvc;
using cdscntapimkpwebapp1.Models;
using cdscntapimkpwebapp1.Models.OrderManager;
using Microsoft.AspNetCore.Http;
using cdscntapimkpwebapp1.Enumeration;
using CdscntMkpApiReference_Prod;
using System.Linq;
using System;
using System.Collections.Generic;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace cdscntapimkpwebapp1.Controllers
{
    public class OrderManagerController : Controller
    {
        // GET: /<controller>/
        const string SessionLogin = "_Login";
        const string SessionToken = "_Token";
        const string SessionEnvironment = "_Environment";

        // OfferManager _OfferManager;
        //Autentication _Autentication;
        /*public IActionResult Index()
        {
            _OfferManager = new OfferManager();
            return View(__OfferManager);
        }*/

        public IActionResult Welcome()
        {
            //ViewData["Message"] = "Hello " + name;
            //ViewData["NumTimes"] = numTimes;

            return View();
        }

        public void GetSessionData(ref Request MyRequest)
        {
          /*  if (HttpContext.Session.GetString(SessionToken) != null)
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

        public ActionResult ValidateOrderListRequest()
        {
            Request MyRequest = new ValidateOrderListRequest();
          /*  if (HttpContext.Session.GetString(SessionToken) != null)
            {
                MyRequest._Login = HttpContext.Session.GetString(SessionLogin);
                MyRequest._Token = HttpContext.Session.GetString(SessionToken);
                MyRequest._EnvironmentSelected = (EnvironmentEnum)Enum.Parse(typeof(EnvironmentEnum), HttpContext.Session.GetString(SessionEnvironment));
            }*/
            return View(MyRequest);
        }
        [HttpPost]
        public ActionResult ValidateOrderListResponse(ValidateOrderListRequest MyRequest)
        {
            string[] SellerProductIdList = Request.Form["SellerProductid[]"].ToArray();
            string[] AcceptationStateList = Request.Form["AcceptationState[]"].ToArray();
            string[] ProductConditionList = Request.Form["ProductCondition[]"].ToArray();

            int length = SellerProductIdList.Length;
            List<ValidateOrderLine> ValidateOrderLineList = new List<ValidateOrderLine>();
            if (SellerProductIdList.GetLength(0) > 0)
            {
                foreach (string MySellerProductId in SellerProductIdList)
                {


                    ValidateOrderLine MyValidateOrderLine = new ValidateOrderLine()
                    {
                        SellerProductId = MySellerProductId,
                        AcceptationState = (AcceptationStateEnum)Enum.Parse(typeof(AcceptationStateEnum), AcceptationStateList[0]),
                        ProductCondition = (ProductConditionEnum)Enum.Parse(typeof(ProductConditionEnum), ProductConditionList[0]),
                    };
                    ValidateOrderLineList.Add(MyValidateOrderLine);
                }
                MyRequest._ValidateOrderListMessage.OrderList[0].OrderLineList = ValidateOrderLineList.ToArray();
                MyRequest.GetHeaderMessage();
                SetSessionData(MyRequest);
            }
            return View(new ValidateOrderListResponse(MyRequest));
        }

        public ActionResult GetOrderListRequest()
        {
            Request MyRequest = new GetOrderListRequest();
         /*   if (HttpContext.Session.GetString(SessionToken) != null)
            {
                MyRequest._Login = HttpContext.Session.GetString(SessionLogin);
                MyRequest._Token = HttpContext.Session.GetString(SessionToken);
                MyRequest._EnvironmentSelected = (EnvironmentEnum)Enum.Parse(typeof(EnvironmentEnum), HttpContext.Session.GetString(SessionEnvironment));
            }*/
            return View(MyRequest);
        }
        [HttpPost]
        public ActionResult GetOrderListMessage(GetOrderListRequest MyRequest)
        {
          
            MyRequest.GetHeaderMessage();
            SetSessionData(MyRequest);
            return View(new GetOrderListMessage(MyRequest));
        }

    }
}
