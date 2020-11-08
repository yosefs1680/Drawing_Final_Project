using Contracts;
using Contracts.DTO;
using DrawnigContracts.DTO;
using DrawnigContracts.DTO.documentsDTO.Request;
using DrawnigContracts.DTO.documentsDTO.Response;
using DrawnigContracts.Interface;
using DrawnigContracts.Interface.Documents;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DocumentsService
{
    [Register(Policy.Transient, typeof(IGetAllMyDocsService))]
    public class GetAllMyDocsService: IGetAllMyDocsService
    {
        IDocsDal _dal;

        public GetAllMyDocsService(IDocsDal dal)
        {
            _dal = dal;
        }
        public Response GetAllMyDocs(string userId)
        {
            Response retval;
            try
            {
                var DsDocs = _dal.GetAllDocsOfUser(userId);
                if (DsDocs.Tables[0].Rows.Count > 0)
                {
                    var listResult = convertDataToDocsList(DsDocs);
                    retval = new GetAllDocsResponseOk(listResult);
                }
                else
                {
                    retval = new GetAllDocsResponseError("There are no document for this user");
                }
            }
            catch 
            {
                retval = new AppResponseError("Error, can't fetch documents");
            }
            return retval;
        }
        private List<CreateDocsRequest> convertDataToDocsList(DataSet ds)
        {
            List<CreateDocsRequest> retval = new List<CreateDocsRequest>();
            var docsRows = ds.Tables[0].Rows;
            for (int i = 0; i < docsRows.Count; i++)
            {
                var elmnt = new CreateDocsRequest();
                try
                {
                    elmnt.Owner = docsRows[i].Field<string>("OWNER");
                    elmnt.DocId = docsRows[i].Field<string>("DOCID");
                    elmnt.DocUrl = docsRows[i].Field<string>("DOCURL");
                    elmnt.DocName = docsRows[i].Field<string>("DOCNAME");

                    retval.Add(elmnt);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            return retval;
        }
    }
}
