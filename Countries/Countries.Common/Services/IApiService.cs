﻿using Countries.Common.Responses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace Countries.Common.Services
{
    public interface IApiService
    {
        Task<Response> GetListAsync<T>(string urlBase, string servicePrefix, string controller);
    }
}
