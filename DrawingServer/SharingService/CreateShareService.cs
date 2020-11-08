using Contracts;
using Contracts.DTO;
using DrawnigContracts.DTO;
using DrawnigContracts.DTO.Sharing.Request;
using DrawnigContracts.Interface.Sharing;
using System;

namespace SharingService
{
    [Register(Policy.Transient, typeof(ICreateShareService))]
    public class CreateShareService : ICreateShareService
    {
        ISharingDal _dal;
        public CreateShareService(ISharingDal dal)
        {
            _dal = dal;
        }
        public Response CreateShare(ShareRequest request)
        {
            Response retval;
            try
            {
                var dsShare = _dal.CreateShare(request);
                retval = new ResponseOk<string>("Share was Created!");
            
            }
            catch (Exception ex)
            {
                retval = new AppResponseError("Sharing not created\n" + ex.Message);
            }
            return retval;
        }
    }
}
    