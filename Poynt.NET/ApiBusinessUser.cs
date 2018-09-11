﻿using Poynt.NET.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poynt.NET
{
    public class ApiBusinessUser : Api<BusinessUser, List<BusinessUser>>
    {
        public ApiBusinessUser(PoyntSDK sdk) : base(sdk, Constants.POYNT_API_HOST + Constants.API_BUSINESS_USERS)
        {

        }

        public async Task<BusinessUser> Get(string businessId, int userId)
        {
            return await GetFromBusiness<BusinessUser>(businessId, userId.ToString());
        }
    }
}
