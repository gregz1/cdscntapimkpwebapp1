using CdscntMkpApiReference_Prod;

namespace cdscntapimkpwebapp1.Models
{
    public class GetProductListRequest : Request
    {
       public ProductFilter _ProductFilter { get; set; }

        public ProductListMessage _ProductListMessage;

        public GetProductListRequest()
        {
            _ProductFilter = new ProductFilter();
            _Parameters.Add("Code Category", "");


        }        
    }
}
