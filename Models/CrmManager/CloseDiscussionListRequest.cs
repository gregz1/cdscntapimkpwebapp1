using CdscntMkpApiReference_Prod;

namespace cdscntapimkpwebapp1.Models.CrmManager
{
    public class CloseDiscussionListRequest:Request
    {
            public CloseDiscussionRequest _CloseDiscussionRequest { get; set; }


            public CloseDiscussionListRequest()
            {
                _CloseDiscussionRequest = new CloseDiscussionRequest();
            }

        
    }
}
