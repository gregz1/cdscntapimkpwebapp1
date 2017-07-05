using System.Threading.Tasks;
using CdscntMkpApiReference_Prod;
using System.Xml.Serialization;

namespace cdscntapimkpwebapp1.Models.CrmManager
{
    public class GetDiscussionMailMessage:Message
    {
        public Task<DiscussionMailListMessage> _DiscussionMailListMessage;
        public GetDiscussionMailMessage(GetDiscussionsMailRequest MyRequest)
        {
            _Environment = MyRequest._EnvironmentSelected;
            GetService();
            _DiscussionMailListMessage = _MarketplaceAPIService.GetDiscussionMailListAsync(MyRequest._HeaderMessage,MyRequest._GetDiscussionMailListRequest);
            XmlSerializer xmlSerializer = new XmlSerializer(_DiscussionMailListMessage.GetType());

            _RequestXML = _RequestInterceptor.LastRequestXML;
            _MessageXML = _RequestInterceptor.LastResponseXML;
        }
    }
}
