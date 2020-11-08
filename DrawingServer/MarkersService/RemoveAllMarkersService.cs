using Contracts;
using Contracts.DTO;
using DrawnigContracts.DTO;
using DrawnigContracts.DTO.Markers.Request;
using DrawnigContracts.Interface.Markers;
using System;

namespace MarkersService
{
    [Register(Policy.Transient, typeof(IRemoveAllMarkersService))]
    class RemoveAllMarkersService: IRemoveAllMarkersService
    {
        IMarkersDal _dal;
        public RemoveAllMarkersService(IMarkersDal dal)
        {
            _dal = dal;
        }
        public Response RemoveAllMarkers(AllMarkersByDocIdRequest request)
        {
            Response retval;
            try
            {
                _dal.RemoveAllMarkers(request.DocId);
                retval = new RemoveAllMarkersResponseOk("All markers were deleted!");
            }
            catch (Exception ex)
            {
                retval = new RemoveAllMarkersResponseErr("Can't delete markers now\n" + ex.Message);
            }
            return retval;
        }
    }
}
