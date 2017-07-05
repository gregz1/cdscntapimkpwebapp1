using System.Collections.Generic;
using CdscntMkpApiReference_Prod;

namespace cdscntapimkpwebapp1.Models.OfferManager
{
    public class GetOfferPackageSubmissionResultRequest:Request
    {
            public OfferFilter _OfferFilter { get; set; }
            public OfferIntegrationReportMessage _OfferIntegrationReportMessage { get; set; }

            public GetOfferPackageSubmissionResultRequest()
            {
                _hasParameters = true;

                _Autentication = new Autentication();

                _OfferFilter = new OfferFilter();

                _Parameters = new Dictionary<string, string>();
                _Parameters.Add("PackageID", "");
            }
 }

}
