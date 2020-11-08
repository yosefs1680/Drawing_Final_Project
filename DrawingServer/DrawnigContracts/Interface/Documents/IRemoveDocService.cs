using Contracts.DTO;

namespace DrawnigContracts.Interface
{
    public interface IRemoveDocService
    {
        public Response removeDoc(string docId);
    }
}