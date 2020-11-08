using Contracts.DTO;

namespace DrawnigContracts.DTO
{
    public class AppResponseError : ResponseError<string>
    {
        public AppResponseError(string msg) : base(msg)
        {
                
        }
    }
}
