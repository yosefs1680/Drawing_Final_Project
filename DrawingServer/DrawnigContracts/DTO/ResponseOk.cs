using Contracts.DTO;

namespace DrawnigContracts.DTO
{
    public class ResponseOk<T> : Response
    {
        public ResponseOk(T data)
        {
            Data = data;
        }
        public T Data { get; set; }
    }
}
