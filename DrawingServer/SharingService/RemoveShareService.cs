using Contracts;
using Contracts.DTO;
using DrawnigContracts.DTO;
using DrawnigContracts.DTO.Sharing.Request;
using DrawnigContracts.Interface.Sharing;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharingService
{
    [Register(Policy.Transient, typeof(IRemoveShareService))]
    public class RemoveShareService : IRemoveShareService
    {
        ISharingDal _dal;
        public RemoveShareService(ISharingDal dal)
        {
            _dal = dal;
        }
        public Response removeShare (ShareRequest request)
        {
            Response retval;
            try
            {
                var dsShare = _dal.RemoveShare(request);
                retval = new ResponseOk<string>("Remove share for this user");
            }
            catch (Exception ex)
            {
                retval = new AppResponseError("Can't remove now\n" + ex.Message); 
            }
            return retval;
        }
    }
}
