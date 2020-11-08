using Contracts;
using Contracts.DTO;
using DrawnigContracts.DTO;
using DrawnigContracts.DTO.Sharing.Request;
using DrawnigContracts.Interface.Sharing;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SharingService
{
    [Register(Policy.Transient, typeof(IGetMySharedDocsService))]
    public class GetMySharedDocsService : IGetMySharedDocsService
    {
        ISharingDal _dal;
        public GetMySharedDocsService(ISharingDal dal)
        {
            _dal = dal;
        }
        public Response GetMySharedDocs(Login request)
        {
            Response retval;
            try
            {
                var dsSharing = _dal.GetMySharedDocs(request); 
                if(dsSharing.Tables[0].Rows.Count > 0)
                {
                    var listResult = ConvertDataToShareList(dsSharing);
                    retval = new ResponseOk<List<ShareRequest>>(listResult);
                }
                else
                {
                    retval = new ResponseError<string>("There is no Share docs to present!");
                }
            }
            catch
            {
                retval = new AppResponseError("Error, can't fetch documents");
            }
            return retval;
        }

        private List<ShareRequest> ConvertDataToShareList(DataSet ds)
        {
            List<ShareRequest> retval = new List<ShareRequest>();
            var shareRows = ds.Tables[0].Rows;
            for (int i = 0; i < shareRows.Count; i++)
            {
                var shareDoc = new ShareRequest();
                try
                {
                    shareDoc.UserId = shareRows[i].Field<string>("USERID");
                    shareDoc.DocId = shareRows[i].Field<string>("DOCID");
                  
                    retval.Add(shareDoc);
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
