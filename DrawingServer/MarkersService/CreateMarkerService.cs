using Contracts;
using Contracts.DTO;
using DrawnigContracts.DTO;
using DrawnigContracts.DTO.Markers.Request;
using DrawnigContracts.Interface.Markers;
using System;

namespace MarkersService
{
    [Register(Policy.Transient, typeof(ICreateMarkerService))]
    public class CreateMarkerService : ICreateMarkerService
    {
        IMarkersDal _dal;
        public CreateMarkerService(IMarkersDal dal)
        {
            _dal = dal;
        }

        public Response CreateMarker(CreateMarkerRequest request)
        {
            Response retval = new AppResponseError("Can't create marker\n");
            try
            {
                var dsMarker = _dal.CreateMarker(request);
                if(dsMarker.Tables[0].Rows.Count == 1)
                {
                    retval = new CreateMarkerResponseOk("Marker Created");
                }
            }
            catch (Exception ex)
            {
                retval = new CreateMarkerResponseErr("Can't create marker\n" + ex.Message);
            }
            return retval;
        }
    }
}
