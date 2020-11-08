using Contracts.DTO;

namespace DrawnigContracts.DTO
{
    public class ResponseError<T> : Response
    {
        public ResponseError(T data)
        {
            Data = data;
        }
        public T Data { get; set; }
    }
}
