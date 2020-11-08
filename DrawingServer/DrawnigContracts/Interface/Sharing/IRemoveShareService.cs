using Contracts.DTO;
using DrawnigContracts.DTO.Sharing.Request;

namespace DrawnigContracts.Interface.Sharing
{
    public interface IRemoveShareService
    {
        public Response removeShare(ShareRequest request);
    }
}
