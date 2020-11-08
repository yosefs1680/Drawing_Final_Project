using Contracts;
using Contracts.DTO;
using DrawnigContracts.DTO;
using DrawnigContracts.DTO.Markers.Request;
using DrawnigContracts.Interface.Markers;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarkersService
{
    [Register(Policy.Transient, typeof(IRemoveMarkerService))]
    public class RemoveMarkerService : IRemoveMarkerService
    {
        IMarkersDal _dal;
        public RemoveMarkerService(IMarkersDal dal)
        {
            _dal = dal;
        }

        public Response RemoveMarker(MarkerKeysRequest request)
        {
            Response retval;
            try
            {
                _dal.RemoveMarker(request);
                retval = new RemoveMarkerResponseOk("Marker was deleted!");
            }
            catch(Exception ex)
            {
                retval = new RemoveMarkerResponseErr("can't delete now\n" + ex.Message);
            }
            return retval;
        }
    }
}
