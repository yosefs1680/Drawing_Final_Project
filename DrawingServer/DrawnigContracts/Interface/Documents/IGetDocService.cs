using Contracts.DTO;

namespace DrawnigContracts.Interface
{
    public interface IGetDocService
    {
        public Response getDoc(string docId);
    }
}