using System.Collections.Generic;
using CdscntMkpApiReference_Prod;
using System.Xml.Serialization;

namespace cdscntapimkpwebapp1.Models
{
    public class Message
    {

        public string _MessageXML { get; set; }
        public string _RequestXML { get; set; }

        public string _Token { get; set; }
        public bool _OperationSuccess { get; set; }

        protected XmlSerializer _xmlSerializer;
        public string _ErrorMessage{ get; set; }
        public  Error[] _ErrorList { get; set; }
        public string _ErrorType { get; set; }
        public string _InnerErrorMessage { get; set; }

        protected MarketplaceAPIServiceClient _MarketplaceAPIService;

        protected InspectorBehavior _RequestInterceptor;
        public Dictionary<string, string> _Parameters { get; set; }
        protected Enumeration.EnvironmentEnum _Environment;
        string _EndPointAddress;
        protected ServiceBaseAPIMessage ApiMessage;
        

        public Message()
        {
            _Parameters = new Dictionary<string, string>();
            _RequestInterceptor = new InspectorBehavior();
            _OperationSuccess = true;
        }


        public void GetService()
        {
            if (_Environment == Enumeration.EnvironmentEnum.Production)
                _EndPointAddress = "https://wsvc.cdiscount.com/MarketplaceAPIService.svc";
            else if (_Environment == Enumeration.EnvironmentEnum.Local)
                _EndPointAddress = "http://localhost:8030/MarketplaceAPIService.svc";
            else if (_Environment == Enumeration.EnvironmentEnum.Preproduction)
                _EndPointAddress = "https://wsvc.preprod-cdiscount.com/MarketplaceAPIService.svc";
            else if (_Environment == Enumeration.EnvironmentEnum.Recette)
                _EndPointAddress = "https://wsvc.recette-cdiscount.com/MarketplaceAPIService.svc";

            _MarketplaceAPIService = new MarketplaceAPIServiceClient(MarketplaceAPIServiceClient.EndpointConfiguration.BasicHttpBinding_IMarketplaceAPIService, _EndPointAddress);
            _MarketplaceAPIService.Endpoint.EndpointBehaviors.Add(_RequestInterceptor);


        }

        public void GetService(Request MyRequest)
        {
            _Environment = MyRequest._EnvironmentSelected;
            if (_Environment == Enumeration.EnvironmentEnum.Production)
                _EndPointAddress = "https://wsvc.cdiscount.com/MarketplaceAPIService.svc";
            else if (_Environment == Enumeration.EnvironmentEnum.Local)
                _EndPointAddress = "http://localhost:8030/MarketplaceAPIService.svc";
            else
                _EndPointAddress = "https://wsvc.preprod-cdiscount.com/MarketplaceAPIService.svc";

            _MarketplaceAPIService = new MarketplaceAPIServiceClient(MarketplaceAPIServiceClient.EndpointConfiguration.BasicHttpBinding_IMarketplaceAPIService, _EndPointAddress);
            _MarketplaceAPIService.Endpoint.EndpointBehaviors.Add(_RequestInterceptor);


        }


    }
}
