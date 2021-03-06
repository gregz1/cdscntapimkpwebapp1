﻿using System.Threading.Tasks;
using CdscntMkpApiReference_Prod;
using System.Xml.Serialization;

namespace cdscntapimkpwebapp1.Models
{
    public class GetProductPackageMatchingFileDataMessage:Message
    {
        public PackageFilter _PackageFilter { get; set; }

        public GetProductPackageMatchingFileDataMessage(Request MyRequest)
        {

            _Environment = MyRequest._EnvironmentSelected;
            GetService();
            _PackageFilter = new PackageFilter();
            long j;
            if (long.TryParse(MyRequest._Parameters["Values"], out j))
                _PackageFilter.PackageID = j;
            var _ProductIntegrationReportMessage = _MarketplaceAPIService.GetProductPackageProductMatchingFileDataAsync(MyRequest._HeaderMessage, _PackageFilter);
            XmlSerializer xmlSerializer = new XmlSerializer(_ProductIntegrationReportMessage.Result.GetType());

            _RequestXML = _RequestInterceptor.LastRequestXML;
            _MessageXML = _RequestInterceptor.LastResponseXML;
        }
    }
}
