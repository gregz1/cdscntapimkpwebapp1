using CdscntMkpApiReference_Prod;

namespace cdscntapimkpwebapp1.Models.CrmManager
{
    
    public class GetOfferQuestionListRequest:Request
    {
        public OfferQuestionFilter _OfferQuestionFilter;
        public GetOfferQuestionListRequest()
        {
            _OfferQuestionFilter = new OfferQuestionFilter();
        }
    }
}
