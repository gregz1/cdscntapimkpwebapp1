using System.Threading.Tasks;
using CdscntMkpApiReference_Prod;
using System.Xml.Serialization;

namespace cdscntapimkpwebapp1.Models.CrmManager
{
    public class GetOfferQuestionListMessage:Message
    {
        Task<OfferQuestionListMessage> _OfferQuestionListMessage;
       public GetOfferQuestionListMessage(GetOfferQuestionListRequest MyRequest)
        { 
            _Environment = MyRequest._EnvironmentSelected;
            GetService();
            _OfferQuestionListMessage = _MarketplaceAPIService.GetOfferQuestionListAsync(MyRequest._HeaderMessage,MyRequest._OfferQuestionFilter);
            XmlSerializer xmlSerializer = new XmlSerializer(_OfferQuestionListMessage.GetType());

            _RequestXML = _RequestInterceptor.LastRequestXML;
            _MessageXML = _RequestInterceptor.LastResponseXML;
        }
    }
}
