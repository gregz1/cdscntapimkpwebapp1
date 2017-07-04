using CdscntMkpApiReference_Prod;

namespace cdscntapimkpwebapp1.Models
{

    
    public class GetModelListRequest : Request
    {
        public ModelFilter _ModelFilter;
        public GetModelListRequest()
        {
            _ModelFilter = new ModelFilter();
            _Parameters.Add("Code Category", "");
        }

    }
}
