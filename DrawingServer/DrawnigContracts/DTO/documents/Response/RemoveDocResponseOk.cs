namespace DrawnigContracts.DTO.documentsDTO.Response
{
    public class RemoveDocResponseOk : ResponseOk<string> 
    {
        public RemoveDocResponseOk(string msg) : base(msg) { }
    }
}
