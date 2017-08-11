using System.Threading.Tasks;
using CdscntMkpApiReference_Prod;


namespace cdscntapimkpwebapp1.Models
{
    public class GetModelListMessage : Message
    {
        public Task<ProductModelListMessage> _ProductModelListMessage { get; set; }

        public ModelFilter _ModelFilter { get; set; }


        public GetModelListMessage(Request MyRequest)
        {
            try
            {
                _Environment = MyRequest._EnvironmentSelected;
                GetService();
                _ModelFilter = new ModelFilter();
                _ModelFilter.CategoryCodeList = MyRequest._Parameters["Values"].Split(';');
                var _ModelListMessage = _MarketplaceAPIService.GetModelListAsync(MyRequest._HeaderMessage, _ModelFilter);

                _RequestXML = _RequestInterceptor.LastRequestXML;
                _MessageXML = _RequestInterceptor.LastResponseXML;

                if (_ModelListMessage != null)
                {
                    if (_ModelListMessage.Result != null)
                    {
                        _ErrorMessage = _ModelListMessage.Result.ErrorMessage;
                        if (_ModelListMessage.Result.ErrorList != null)
                            _ErrorList = _ModelListMessage.Result.ErrorList;
                    }
                }
            }

            catch (System.Exception ex)
            {
                _OperationSuccess = false;
                _ErrorMessage = ex.Message;
                _ErrorType = ex.HelpLink;

            }

        }
    }
}
