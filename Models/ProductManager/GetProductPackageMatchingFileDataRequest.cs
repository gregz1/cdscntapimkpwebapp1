using System.Collections.Generic;
using CdscntMkpApiReference_Prod;

namespace cdscntapimkpwebapp1.Models
{
    public class GetProductPackageMatchingFileDataRequest:Request
    {
        public GetProductPackageMatchingFileDataRequest()
        {
            _hasParameters = true;

            _Autentication = new Autentication();

            _Parameters = new Dictionary<string, string>();
            _Parameters.Add("PackageID", "");
        }
    }
}
