using CdscntMkpApiReference_Prod;

namespace cdscntapimkpwebapp1.Models.CrmManager
{
    public class GetDiscussionsMailRequest:Request
    {
        public GetDiscussionMailListRequest _GetDiscussionMailListRequest;


        public GetDiscussionsMailRequest()
        {
            _GetDiscussionMailListRequest = new GetDiscussionMailListRequest();
        }


    }
}
