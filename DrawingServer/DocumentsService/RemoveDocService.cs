using Contracts;
using Contracts.DTO;
using DrawnigContracts.DTO;
using DrawnigContracts.DTO.documentsDTO.Response;
using DrawnigContracts.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentsService
{
    [Register(Policy.Transient, typeof(IRemoveDocService))]
    class RemoveDocService : IRemoveDocService
    {
        IDocsDal _dal;
        public RemoveDocService(IDocsDal dal)
        {
            _dal = dal;
        }
        public Response removeDoc(string docId)
        {
            Response retval = null;
            try
            {
                if (_dal.GetDoc(docId).Tables[0].Rows.Count == 1) // doc exsist
                {
                    _dal.RemoveDoc(docId);
                    //check removing
                    var docRow = _dal.GetDoc(docId).Tables[0].Rows;
                    if (docRow.Count == 0) // success - the doc isn't found
                    {
                        retval = new RemoveDocResponseOk("Document removed successfuly!");
                    }
                    else
                    {
                        retval = new RemoveDocResponseError("Removing failed!"); 
                    }
                }
                else
                {
                    retval = new RemoveDocResponseError("This document doesn't exist!"); 
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
