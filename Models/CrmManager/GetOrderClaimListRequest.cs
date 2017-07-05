using CdscntMkpApiReference_Prod;

namespace cdscntapimkpwebapp1.Models.CrmManager
{

    public class GetOrderClaimListRequest:Request
    {
        public OrderClaimFilter _OrderClaimFilter;
        public GetOrderClaimListRequest()
        {
            _OrderClaimFilter = new OrderClaimFilter();

            _OrderClaimFilter.OrderNumberList = new string[1];
            //_OrderClaimFilter.OrderNumberList[0]= "17021521164NH3V";
        }


    }
}
