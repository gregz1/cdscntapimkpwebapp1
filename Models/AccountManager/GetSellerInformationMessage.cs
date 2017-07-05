﻿using System.Threading.Tasks;
using CdscntMkpApiReference_Prod;


namespace cdscntapimkpwebapp1.Models.AccountManager
{
    /// <summary>
    /// ess
    /// </summary>
    public class GetSellerInformationMessage :Message
    {
            public Task<SellerMessage> _SellerMessage { get; set; }


            public GetSellerInformationMessage(Request MyRequest)
            {

                _Environment = MyRequest._EnvironmentSelected;
                GetService();
                _SellerMessage = _MarketplaceAPIService.GetSellerInformationAsync(MyRequest._HeaderMessage);
                //  XmlSerializer xmlSerializer = new XmlSerializer(_AllCategoryTreeMessage.Result.GetType());

                _RequestXML = _RequestInterceptor.LastRequestXML;
                _MessageXML = _RequestInterceptor.LastResponseXML;

            }

        }
    }
