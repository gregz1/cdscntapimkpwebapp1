using System.Threading.Tasks;
using CdscntMkpApiReference_Prod;


namespace cdscntapimkpwebapp1.Models.AccountManager
{
    public class GetGlobalConfigurationMessage: Message
    {
            public Task<GlobalConfigurationMessage> _GlobalConfigurationMessage { get; set; }


            public GetGlobalConfigurationMessage(Request MyRequest)
            {

                _Environment = MyRequest._EnvironmentSelected;
                GetService();
                _GlobalConfigurationMessage = _MarketplaceAPIService.GetGlobalConfigurationAsync(MyRequest._HeaderMessage);
                //  XmlSerializer xmlSerializer = new XmlSerializer(_AllCategoryTreeMessage.Result.GetType());

                _RequestXML = _RequestInterceptor.LastRequestXML;
                _MessageXML = _RequestInterceptor.LastResponseXML;

            }

        
    }
}
