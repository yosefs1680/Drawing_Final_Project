using DrawnigContracts.DTO;
using DrawnigContracts.DTO.Sharing.Request;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DrawnigContracts.Interface.Sharing
{
    public interface ISharingDal
    {
        public DataSet CreateShare(ShareRequest request);
        public DataSet GetMySharedDocs(Login request);
        public DataSet RemoveShare(ShareRequest request);
    }
}
