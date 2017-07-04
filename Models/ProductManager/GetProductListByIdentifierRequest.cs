using CdscntMkpApiReference_Prod;

namespace cdscntapimkpwebapp1.Models
{
    public class GetProductListByIdentifierRequest : Request
    {
       public IdentifierRequest _IdentifierRequest { get; set; }

        public ProductListMessage _ProductListMessage;

        public GetProductListByIdentifierRequest()
        {
            _IdentifierRequest = new IdentifierRequest();
            _Parameters.Add("IdentifierType", "");
            _Parameters.Add("EAN", "");


        }
    }
}
