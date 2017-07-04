using CdscntMkpApiReference_Prod;

namespace cdscntapimkpwebapp1.Models
{
    public class SubmitProductPackageRequest : Request
    {
        public ProductPackageRequest _ProductPackageRequest { get; set; }

        public SubmitProductPackageMessage _SubmitProductPackageMessage;
        public SubmitProductPackageRequest()
        {
            _hasParameters = true;
            _ProductPackageRequest = new ProductPackageRequest();
            _Parameters.Add("zipfilepath","");
        }      
    }
}
