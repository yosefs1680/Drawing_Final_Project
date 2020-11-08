using DrawnigContracts.DTO.documentsDTO.Request;
using System.Data;

namespace DrawnigContracts.Interface
{
    public interface IDocsDal
    {
        public DataSet CreateDoc(CreateDocsRequest request);
        public DataSet GetDoc(string docId);
        public DataSet RemoveDoc(string docId);
        public DataSet GetAllDocsOfUser(string userId);

    }
}
