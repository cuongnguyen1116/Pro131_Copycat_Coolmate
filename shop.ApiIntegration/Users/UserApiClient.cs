using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using shop.ViewModels.Common;
using shop.ViewModels.System.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.ApiIntegration.Users
{
    public class UserApiClient : BaseApiClient, IUserApiClient
    {
        private readonly IHttpContextAccessor _contextAccessor;

        public UserApiClient(HttpClient httpClient, IConfiguration configuration) : base(httpClient, configuration)
        {
        }

        public async Task<ApiResult<bool>> Authencate(LoginRequest loginRequest)
        {
            //var session = _contextAccessor.HttpContext.Session.getstring()
            return null;
        } 
    }
}
