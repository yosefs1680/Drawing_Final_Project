using Contracts.DTO;

namespace DrawnigContracts.Interface
{
    public interface IRemoveUserService
    {
        public Response RemoveUser(string userId);
    }
}