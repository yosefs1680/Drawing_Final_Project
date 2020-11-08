using DrawnigContracts.DTO.documentsDTO.Request;

namespace DrawnigContracts.DTO.documentsDTO.Response
{
    public class GetDocResponseOk : ResponseOk<CreateDocsRequest> 
    {
        public GetDocResponseOk(CreateDocsRequest request) : base(request) { }
    }
}
