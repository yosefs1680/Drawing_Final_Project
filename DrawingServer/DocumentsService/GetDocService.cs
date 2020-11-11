using Contracts;
using Contracts.DTO;
using DrawnigContracts.DTO;
using DrawnigContracts.DTO.documents;
using DrawnigContracts.DTO.documentsDTO.Request;
using DrawnigContracts.DTO.documentsDTO.Response;
using DrawnigContracts.Interface;
using System;
using System.Data;

namespace DocumentsService
{
    [Register(Policy.Transient, typeof(IGetDocService))]
    class GetDocService : IGetDocService
    {
        IDocsDal _dal;
        public GetDocService(IDocsDal dal)
        {
            _dal = dal;
        }
        public Response getDoc(string docId)
        {
            Response retval = null;
            try
            {               
                var dataSet = _dal.GetDoc(docId);
                if (dataSet.Tables[0].Rows.Count == 0) // dohsnt exist
                {
                    retval = new GetDocResponseError("Document doesn't exist");
                }
                else if (dataSet.Tables[0].Rows.Count == 1)
                {
                    Document request = convertDataSetToClass(dataSet);
                    retval = new GetDocResponseOk(request);
                }
            } catch (Exception ex)
            {
                retval = new AppResponseError(ex.Message);
            }
            return retval;
        }

        private Document convertDataSetToClass(DataSet data)
        {
            Document retval = new Document();
            var row = data.Tables[0].Rows;
            if (row.Count > 0)
            {
                try
                {
                    retval.Owner = row[0].Field<string>("OWNER");
                    retval.DocId = row[0].Field<string>("DOCID");
                    retval.DocUrl = row[0].Field<string>("DOCURL");
                    retval.DocName = row[0].Field<string>("DOCNAME");
                }
                catch{
                    
                }
            }
                 return retval;
        }
    }
}
