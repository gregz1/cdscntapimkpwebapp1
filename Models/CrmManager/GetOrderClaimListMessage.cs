using CdscntMkpApiReference_Prod;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace cdscntapimkpwebapp1.Models.CrmManager
{
    public class GetOrderClaimListMessage:Message
    {
        Task<OrderClaimListMessage> _OrderClaimListMessage;
        public GetOrderClaimListMessage(GetOrderClaimListRequest MyRequest)
        {
            _Environment = MyRequest._EnvironmentSelected;
            GetService();
      //      MyRequest._OrderClaimFilter.OrderNumberList[0] = "17021521164NH3V";
            _OrderClaimListMessage = _MarketplaceAPIService.GetOrderClaimListAsync(MyRequest._HeaderMessage, MyRequest._OrderClaimFilter) ;
            XmlSerializer xmlSerializer = new XmlSerializer(_OrderClaimListMessage.GetType());

            _RequestXML = _RequestInterceptor.LastRequestXML;
            _MessageXML = _RequestInterceptor.LastResponseXML;
        }
    }
}
