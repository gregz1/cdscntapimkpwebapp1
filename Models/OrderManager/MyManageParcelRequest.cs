using CdscntMkpApiReference_Prod;

namespace cdscntapimkpwebapp1.Models.OrderManager
{

    public class MyManageParcelRequest : Request
    {
        public ManageParcelRequest _ManageParcelRequest;
        public MyManageParcelRequest()
        {
            _ManageParcelRequest = new ManageParcelRequest();
        }

    }
}
