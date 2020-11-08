using Contracts.DTO;
using DrawnigContracts.DTO.Sharing.Request;

namespace DrawnigContracts.Interface.Sharing
{
    public interface ICreateShareService
    {
        public Response CreateShare(ShareRequest request);
    }
}
