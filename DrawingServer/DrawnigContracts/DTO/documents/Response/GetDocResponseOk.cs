using DrawnigContracts.DTO.documents;
using DrawnigContracts.DTO.documentsDTO.Request;

namespace DrawnigContracts.DTO.documentsDTO.Response
{
    public class GetDocResponseOk : ResponseOk<Document> 
    {
        public GetDocResponseOk(Document request) : base(request) { }
    }
}
