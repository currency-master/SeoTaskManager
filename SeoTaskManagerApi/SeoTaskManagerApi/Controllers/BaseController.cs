using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeoTaskManagerApi.Controllers
{
    public abstract class BaseApiController : ControllerBase
    {
        protected int GetUserId()
        {
            return int.Parse(User.Claims.First(i => i.Type == "UserId").Value);
        }
    }
}
