using Contracts;
using Contracts.DTO;
using DrawnigContracts.DTO;
using DrawnigContracts.DTO.documentsDTO.Request;
using DrawnigContracts.DTO.documentsDTO.Response;
using DrawnigContracts.Interface;
using System;

namespace DocumentsService
{
    [Register(Policy.Transient, typeof(ICreateDocService))]
    public class CreateDocService : ICreateDocService
    {
        IDocsDal _dal;
        public CreateDocService(IDocsDal dal)
        {
            _dal = dal;
        }
        public Response createDoc(CreateDocsRequest request)
        {
            Response retval = new CreateDocResponseDocExist("Document allready exist");
            try
            {
                _dal.CreateDoc(request);
                //check if doc created:
                var newDoc = _dal.GetDoc(request.DocId).Tables[0].Rows;
                if (newDoc.Count == 1)
                {
                    retval = new CreateDocResponseOk("Document created!");
                }           
            }
            catch (Exception ex)
            {
                retval = new AppResponseError(ex.Message);
            }
            return retval;
        }
    }
}
