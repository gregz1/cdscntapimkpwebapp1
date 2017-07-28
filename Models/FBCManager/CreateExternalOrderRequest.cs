using CdscntMkpApiReference_Prod;

namespace cdscntapimkpwebapp1.Models.OrderManager
{
    public class CreateExternalOrderRequest : Request
    {
        public OrderFilter _OrderFilter { get; set; }

        public CreateExternalOrderRequest()
        {
            _OrderFilter = new OrderFilter();
            _Parameters.Add("OrderReferenceList", "Scopusid;ScopusId;ScopusId");
            _Parameters.Add("BeginCreationDate", "yyyy-mm-ddThh:mm:ss");
            _Parameters.Add("BeginModificationDate", "yyyy-mm-ddThh:mm:ss");
            _Parameters.Add("EndCreationDate", "yyyy-mm-ddThh:mm:ss");
            _Parameters.Add("EndModificationDate", "yyyy-mm-ddThh:mm:ss");
            _Parameters.Add("CorporationCode", "1(Cdiscount) / 16(CdiscountPro)");
            _Parameters.Add("PartnerOrderRef", "PartnerOrderRef");
            _ParametersBool.Add("FetchOrderLines", true);
            _ParametersBool.Add("FetchTrackingInformation", false);
            _ParametersBool.Add("IncludeExternalFbcSiteId", false);

        }

    }
}
